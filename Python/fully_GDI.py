#!/usr/bin/env python3

"""
fully_GDI.py
============

Safe GDI-style visual-effects demo.

Requirements:
    pip install pillow numpy opencv-python pywin32

This program intentionally DOES NOT:
    - write to physical drives
    - terminate Windows processes
    - modify the Windows desktop
    - download or execute remote files

All effects are contained inside this application's window.

Controls:
    ESC / Q  - Exit immediately
    SPACE    - Next effect
    R        - Restart current effect
"""

import tkinter as tk
import random
import math
import time
import colorsys

import numpy as np
from PIL import (
    Image,
    ImageDraw,
    ImageFont,
    ImageFilter,
    ImageEnhance,
    ImageChops,
    ImageOps,
)


# ==============================================================
# CONFIGURATION
# ==============================================================

FPS = 30
EFFECT_TIME = 5.0

BLACK = (0, 0, 0)
WHITE = (255, 255, 255)


# ==============================================================
# MAIN APPLICATION
# ==============================================================

class FullyGDI:
    def __init__(self):
        self.root = tk.Tk()

        self.root.title("fully_GDI.py")
        self.root.configure(bg="black")

        self.fullscreen = True
        self.root.attributes("-fullscreen", True)

        self.width = self.root.winfo_screenwidth()
        self.height = self.root.winfo_screenheight()

        self.canvas = tk.Canvas(
            self.root,
            bg="black",
            highlightthickness=0
        )

        self.canvas.pack(
            fill="both",
            expand=True
        )

        self.running = True
        self.effect_index = 0
        self.effect_start = time.monotonic()
        self.frame = 0

        self.image = Image.new(
            "RGB",
            (self.width, self.height),
            BLACK
        )

        self.photo = None

        self.font_big = self.load_font(42)
        self.font_medium = self.load_font(25)
        self.font_small = self.load_font(17)

        self.effects = [
            ("GRAY BLT", self.gray_blt),
            ("DARK BLT", self.dark_blt),
            ("PIXEL BLT", self.pixel_blt),
            ("BLUR BLT", self.blur_blt),
            ("SHARP BLT", self.sharp_blt),
            ("DETAIL BLT", self.detail_blt),
            ("SMOOTH BLT", self.smooth_blt),
            ("CONTOUR BLT", self.contour_blt),
            ("EMBOSS BLT", self.emboss_blt),
            ("EDGE BLT", self.edge_blt),
            ("MIRROR BLT", self.mirror_blt),
            ("FLIP BLT", self.flip_blt),
            ("ROTATE BLT", self.rotate_blt),
            ("CHOP BLT", self.chop_blt),
            ("BRIGHTNESS BLT", self.brightness_blt),
            ("INVERT BLT", self.invert_blt),
            ("RGB SHIFT", self.rgb_shift),
            ("RGB TRIPLE", self.rgb_triple),
            ("RGB MELT", self.rgb_melt),
            ("JPEG GLITCH", self.jpeg_glitch),
            ("BLOCK GLITCH", self.block_glitch),
            ("SCANLINES", self.scanlines),
            ("STATIC", self.static_noise),
            ("SINE WARP", self.sine_warp),
            ("WAVE FIELD", self.wave_field),
            ("PERSPECTIVE", self.perspective),
            ("POLYGON INVERT", self.polygon_invert),
            ("COLORIZE", self.colorize),
            ("CRT", self.crt),
            ("TERMINAL", self.terminal),
            ("UNKNOWN", self.unknown),
            ("RAINBOW", self.rainbow),
            ("CHAOS", self.chaos),
        ]

        self.root.bind("<Escape>", self.close)
        self.root.bind("<q>", self.close)
        self.root.bind("<Q>", self.close)
        self.root.bind("<space>", self.next_effect)
        self.root.bind("<r>", self.restart_effect)
        self.root.bind("<R>", self.restart_effect)

        self.show_warning()

    # ==========================================================
    # BASIC HELPERS
    # ==========================================================

    def load_font(self, size):
        candidates = [
            "C:/Windows/Fonts/consola.ttf",
            "C:/Windows/Fonts/arial.ttf",
            "arial.ttf",
        ]

        for path in candidates:
            try:
                return ImageFont.truetype(path, size)
            except Exception:
                pass

        return ImageFont.load_default()

    def blank(self):
        return Image.new(
            "RGB",
            (self.width, self.height),
            BLACK
        )

    def capture_base(self):
        """
        Generate a synthetic source image instead of capturing
        the real desktop.
        """

        img = Image.new(
            "RGB",
            (self.width, self.height),
            (5, 5, 8)
        )

        draw = ImageDraw.Draw(img)

        # Gradient-like horizontal bands
        for y in range(0, self.height, 8):
            v = int(12 + 25 * y / max(1, self.height))

            draw.rectangle(
                (0, y, self.width, y + 8),
                fill=(v // 2, v // 3, v)
            )

        # Grid
        for x in range(0, self.width, 80):
            draw.line(
                (x, 0, x, self.height),
                fill=(15, 25, 35),
                width=1
            )

        for y in range(0, self.height, 80):
            draw.line(
                (0, y, self.width, y),
                fill=(15, 25, 35),
                width=1
            )

        # Random visual objects
        for _ in range(70):
            x = random.randint(0, self.width)
            y = random.randint(0, self.height)

            w = random.randint(20, 220)
            h = random.randint(10, 120)

            hue = random.random()
            r, g, b = colorsys.hsv_to_rgb(
                hue,
                0.9,
                random.uniform(0.2, 0.8)
            )

            draw.rectangle(
                (x, y, x + w, y + h),
                outline=(
                    int(r * 255),
                    int(g * 255),
                    int(b * 255)
                ),
                width=random.randint(1, 4)
            )

        # Center marker
        draw.text(
            (self.width // 2, self.height // 2),
            "GDI_OUTPUT",
            fill=(255, 255, 255),
            anchor="mm",
            font=self.font_big
        )

        return img

    def draw_image(self, img):
        img = img.convert("RGB")

        # Scale if an effect generated another size.
        if img.size != (self.width, self.height):
            img = img.resize(
                (self.width, self.height),
                Image.Resampling.BILINEAR
            )

        self.image = img

        self.photo = Image.Image.resize(
            img,
            (self.width, self.height)
        )

        # Convert through ImageTk without requiring it elsewhere.
        from PIL import ImageTk

        self.photo = ImageTk.PhotoImage(img)

        self.canvas.delete("all")

        self.canvas.create_image(
            0,
            0,
            image=self.photo,
            anchor="nw"
        )

    def add_text(self, img, text, y=None):
        draw = ImageDraw.Draw(img)

        if y is None:
            y = self.height - 55

        draw.text(
            (35, y),
            text,
            fill=(255, 255, 255),
            font=self.font_small
        )

    def random_rgb(self):
        return (
            random.randint(0, 255),
            random.randint(0, 255),
            random.randint(0, 255)
        )

    def glitch_text(self):
        return random.choice([
            "gdi_output.py > ?",
            "gdi_output.py > UNKNOWN",
            "IDENTITY: UNKNOWN",
            "TRACE: FAILED",
            "SIGNAL: UNRESOLVED",
            "SUBJECT: UNKNOWN",
            "ERROR://IDENTITY_NOT_FOUND",
            "GDI_OUTPUT > ???",
        ])

    # ==========================================================
    # WINDOW / SEQUENCE
    # ==========================================================

    def show_warning(self):
        self.canvas.delete("all")

        self.canvas.create_text(
            self.width // 2,
            self.height // 2 - 120,
            text="⚠  VISUAL EFFECT DEMO",
            fill="red",
            font=("Consolas", 38, "bold")
        )

        self.canvas.create_text(
            self.width // 2,
            self.height // 2 - 40,
            text="FULL GDI / GLITCH SIMULATION",
            fill="white",
            font=("Consolas", 24, "bold")
        )

        self.canvas.create_text(
            self.width // 2,
            self.height // 2 + 25,
            text="All effects are contained inside this application.",
            fill="#aaaaaa",
            font=("Consolas", 17)
        )

        self.canvas.create_text(
            self.width // 2,
            self.height // 2 + 90,
            text="ESC / Q = EXIT     SPACE = NEXT EFFECT",
            fill="#00ff66",
            font=("Consolas", 18, "bold")
        )

        self.root.after(
            2500,
            self.start
        )

    def start(self):
        self.effect_index = 0
        self.restart_effect()

    def restart_effect(self, event=None):
        self.effect_start = time.monotonic()
        self.frame = 0

    def next_effect(self, event=None):
        self.effect_index += 1

        if self.effect_index >= len(self.effects):
            self.effect_index = 0

        self.restart_effect()

    def close(self, event=None):
        self.running = False

        try:
            self.root.destroy()
        except Exception:
            pass

    def tick(self):
        if not self.running:
            return

        elapsed = time.monotonic() - self.effect_start

        if elapsed >= EFFECT_TIME:
            self.effect_index += 1

            if self.effect_index >= len(self.effects):
                self.effect_index = 0

            self.effect_start = time.monotonic()
            self.frame = 0

        name, effect = self.effects[self.effect_index]

        try:
            img = effect()
            self.draw_image(img)

            self.canvas.create_text(
                25,
                25,
                text=f"[ {name} ]",
                anchor="nw",
                fill="#00ff66",
                font=("Consolas", 16, "bold")
            )

        except Exception as exc:
            self.canvas.delete("all")

            self.canvas.create_text(
                30,
                30,
                anchor="nw",
                text=f"EFFECT ERROR: {exc}",
                fill="red",
                font=("Consolas", 16)
            )

        self.frame += 1

        self.root.after(
            int(1000 / FPS),
            self.tick
        )

    # ==========================================================
    # BASIC IMAGE EFFECTS
    # ==========================================================

    def gray_blt(self):
        img = self.capture_base().convert("L").convert("RGB")
        self.add_text(img, "GRAY_BLT")
        return img

    def dark_blt(self):
        img = self.capture_base().convert("L")

        threshold = 90

        img = img.point(
            lambda p: 255 if p > threshold else 0
        )

        return img.convert("RGB")

    def pixel_blt(self):
        img = self.capture_base()

        small_w = max(40, self.width // 18)
        small_h = max(30, self.height // 18)

        small = img.resize(
            (small_w, small_h),
            Image.Resampling.BILINEAR
        )

        return small.resize(
            (self.width, self.height),
            Image.Resampling.NEAREST
        )

    def blur_blt(self):
        return self.capture_base().filter(
            ImageFilter.GaussianBlur(7)
        )

    def sharp_blt(self):
        return self.capture_base().filter(
            ImageFilter.SHARPEN
        )

    def detail_blt(self):
        return self.capture_base().filter(
            ImageFilter.DETAIL
        )

    def smooth_blt(self):
        return self.capture_base().filter(
            ImageFilter.SMOOTH_MORE
        )

    def contour_blt(self):
        return self.capture_base().filter(
            ImageFilter.CONTOUR
        )

    def emboss_blt(self):
        return self.capture_base().filter(
            ImageFilter.EMBOSS
        )

    def edge_blt(self):
        return self.capture_base().filter(
            ImageFilter.FIND_EDGES
        )

    # ==========================================================
    # TRANSFORM EFFECTS
    # ==========================================================

    def mirror_blt(self):
        return ImageOps.mirror(
            self.capture_base()
        )

    def flip_blt(self):
        return ImageOps.flip(
            self.capture_base()
        )

    def rotate_blt(self):
        angle = math.sin(self.frame / 8) * 15

        return self.capture_base().rotate(
            angle,
            resample=Image.Resampling.BICUBIC,
            expand=False
        )

    def chop_blt(self):
        img = self.capture_base()

        amount = int(
            math.sin(self.frame / 5) * 100
        )

        return ImageChops.offset(
            img,
            amount,
            amount // 2
        )

    # ==========================================================
    # COLOR EFFECTS
    # ==========================================================

    def brightness_blt(self):
        img = self.capture_base()

        factor = 0.4 + (
            abs(math.sin(self.frame / 8)) * 1.8
        )

        return ImageEnhance.Brightness(
            img
        ).enhance(factor)

    def invert_blt(self):
        return ImageOps.invert(
            self.capture_base()
        )

    def colorize(self):
        gray = self.capture_base().convert("L")

        hue = (
            self.frame * 0.015
        ) % 1.0

        r, g, b = colorsys.hsv_to_rgb(
            hue,
            1.0,
            1.0
        )

        return ImageOps.colorize(
            gray,
            black=(0, 0, 0),
            white=(
                int(r * 255),
                int(g * 255),
                int(b * 255)
            )
        )

    # ==========================================================
    # RGB GLITCH EFFECTS
    # ==========================================================

    def rgb_shift(self):
        img = self.capture_base()

        r, g, b = img.split()

        shift = int(
            math.sin(self.frame / 3) * 30
        )

        r = ImageChops.offset(r, shift, 0)
        b = ImageChops.offset(b, -shift, 0)

        return Image.merge(
            "RGB",
            (r, g, b)
        )

    def rgb_triple(self):
        img = self.capture_base()

        r, g, b = img.split()

        offset = int(
            abs(math.sin(self.frame / 4)) * 45
        )

        r = ImageChops.offset(r, offset, 0)
        g = ImageChops.offset(g, 0, offset // 2)
        b = ImageChops.offset(b, -offset, 0)

        return Image.merge(
            "RGB",
            (r, g, b)
        )

    def rgb_melt(self):
        img = self.capture_base()

        output = Image.new(
            "RGB",
            img.size
        )

        for y in range(
            0,
            self.height,
            8
        ):
            shift = int(
                math.sin(
                    y / 70 + self.frame / 4
                ) * 35
            )

            strip = img.crop(
                (
                    0,
                    y,
                    self.width,
                    min(y + 8, self.height)
                )
            )

            output.paste(
                strip,
                (shift, y)
            )

        return output

    # ==========================================================
    # JPEG GLITCH
    # ==========================================================

    def jpeg_glitch(self):
        from io import BytesIO

        img = self.capture_base()

        quality = random.randint(
            5,
            35
        )

        buffer = BytesIO()

        img.save(
            buffer,
            format="JPEG",
            quality=quality
        )

        buffer.seek(0)

        result = Image.open(
            buffer
        ).convert("RGB")

        return result

    # ==========================================================
    # BLOCK GLITCH
    # ==========================================================

    def block_glitch(self):
        img = self.capture_base()

        output = img.copy()

        for _ in range(120):
            x = random.randint(
                0,
                max(0, self.width - 1)
            )

            y = random.randint(
                0,
                max(0, self.height - 1)
            )

            w = random.randint(
                5,
                180
            )

            h = random.randint(
                3,
                50
            )

            x2 = min(
                self.width,
                x + w
            )

            y2 = min(
                self.height,
                y + h
            )

            if x2 <= x or y2 <= y:
                continue

            crop = img.crop(
                (
                    x,
                    y,
                    x2,
                    y2
                )
            )

            shift = random.randint(
                -80,
                80
            )

            output.paste(
                crop,
                (
                    max(
                        0,
                        min(
                            self.width - crop.width,
                            x + shift
                        )
                    ),
                    y
                )
            )

        return output

    # ==========================================================
    # SCANLINES
    # ==========================================================

    def scanlines(self):
        img = self.capture_base()

        draw = ImageDraw.Draw(img)

        for y in range(
            0,
            self.height,
            6
        ):
            draw.rectangle(
                (
                    0,
                    y,
                    self.width,
                    y + 2
                ),
                fill=(0, 0, 0)
            )

        return img

    # ==========================================================
    # STATIC
    # ==========================================================

    def static_noise(self):
        img = self.capture_base()

        draw = ImageDraw.Draw(img)

        for _ in range(1800):
            x = random.randrange(
                self.width
            )

            y = random.randrange(
                self.height
            )

            value = random.randint(
                0,
                255
            )

            size = random.choice(
                [1, 1, 1, 2, 3]
            )

            draw.rectangle(
                (
                    x,
                    y,
                    x + size,
                    y + size
                ),
                fill=(
                    value,
                    value,
                    value
                )
            )

        return img

    # ==========================================================
    # SINE WARP
    # ==========================================================

    def sine_warp(self):
        img = self.capture_base()

        output = Image.new(
            "RGB",
            img.size
        )

        amplitude = 80
        frequency = 70

        for x in range(
            0,
            self.width,
            5
        ):
            offset = int(
                amplitude *
                math.sin(
                    x / frequency +
                    self.frame / 8
                )
            )

            strip = img.crop(
                (
                    x,
                    0,
                    min(x + 5, self.width),
                    self.height
                )
            )

            output.paste(
                strip,
                (
                    x,
                    offset
                )
            )

        return output

    # ==========================================================
    # WAVE FIELD
    # ==========================================================

    def wave_field(self):
        img = self.blank()

        draw = ImageDraw.Draw(img)

        for y in range(
            0,
            self.height,
            25
        ):
            points = []

            for x in range(
                0,
                self.width,
                20
            ):
                yy = (
                    y
                    + math.sin(
                        x / 90 +
                        self.frame / 7
                    ) * 60
                )

                points.append(
                    (x, yy)
                )

            hue = (
                y / max(1, self.height)
                + self.frame * 0.005
            ) % 1.0

            r, g, b = colorsys.hsv_to_rgb(
                hue,
                1,
                1
            )

            draw.line(
                points,
                fill=(
                    int(r * 255),
                    int(g * 255),
                    int(b * 255)
                ),
                width=3
            )

        return img

    # ==========================================================
    # PERSPECTIVE-STYLE EFFECT
    # ==========================================================

    def perspective(self):
        img = self.capture_base()

        angle = math.sin(
            self.frame / 12
        ) * 12

        rotated = img.rotate(
            angle,
            expand=False,
            resample=Image.Resampling.BICUBIC
        )

        scale = (
            1.0 +
            abs(math.sin(
                self.frame / 10
            )) * 0.15
        )

        nw = int(
            self.width * scale
        )

        nh = int(
            self.height * scale
        )

        rotated = rotated.resize(
            (nw, nh),
            Image.Resampling.BICUBIC
        )

        result = Image.new(
            "RGB",
            img.size,
            BLACK
        )

        x = (
            self.width - nw
        ) // 2

        y = (
            self.height - nh
        ) // 2

        result.paste(
            rotated,
            (x, y)
        )

        return result

    # ==========================================================
    # POLYGON INVERSION
    # ==========================================================

    def polygon_invert(self):
        img = self.capture_base()

        inverted = ImageOps.invert(
            img
        )

        mask = Image.new(
            "L",
            img.size,
            0
        )

        draw = ImageDraw.Draw(mask)

        for _ in range(12):
            points = []

            for _ in range(
                random.randint(3, 8)
            ):
                points.append(
                    (
                        random.randint(
                            0,
                            self.width
                        ),
                        random.randint(
                            0,
                            self.height
                        )
                    )
                )

            draw.polygon(
                points,
                fill=255
            )

        return Image.composite(
            inverted,
            img,
            mask
        )

    # ==========================================================
    # CRT EFFECT
    # ==========================================================

    def crt(self):
        img = self.capture_base()

        img = ImageEnhance.Contrast(
            img
        ).enhance(1.6)

        img = ImageEnhance.Color(
            img
        ).enhance(1.8)

        draw = ImageDraw.Draw(img)

        for y in range(
            0,
            self.height,
            4
        ):
            draw.line(
                (0, y, self.width, y),
                fill=(0, 0, 0),
                width=1
            )

        # CRT border
        draw.rectangle(
            (
                15,
                15,
                self.width - 15,
                self.height - 15
            ),
            outline=(80, 80, 80),
            width=2
        )

        return img

    # ==========================================================
    # TERMINAL
    # ==========================================================

    def terminal(self):
        img = self.blank()

        draw = ImageDraw.Draw(img)

        lines = [
            "gdi_output.py > ?",
            "",
            "[GDI] INITIALIZING VISUAL ENGINE",
            "[GDI] ALLOCATING VIRTUAL SURFACE",
            "[GLITCH] CHANNEL SEPARATION",
            "[GLITCH] SIGNAL CORRUPTION",
            "[CRT] SCANLINE PROCESSOR ONLINE",
            "[RGB] SYNCHRONIZATION ERROR",
            "",
            "IDENTITY : UNKNOWN",
            "STATUS   : UNRESOLVED",
            "TRACE    : FAILED",
            "",
            ">>> VISUAL SEQUENCE ACTIVE",
        ]

        y = 100

        for line in lines:
            color = random.choice([
                (0, 255, 80),
                (0, 255, 180),
                (255, 255, 255),
                (255, 50, 90),
            ])

            draw.text(
                (
                    70,
                    y
                ),
                line,
                fill=color,
                font=self.font_medium
            )

            y += 40

        return img

    # ==========================================================
    # UNKNOWN / STALKER-THEME GLITCH
    # ==========================================================

    def unknown(self):
        img = self.blank()

        draw = ImageDraw.Draw(img)

        center_x = self.width // 2
        center_y = self.height // 2

        text = random.choice([
            "U̷N̷K̷N̷O̷W̷N̷",
            "U N K N O W N",
            "[ UNKNOWN ]",
            "???",
        ])

        # RGB ghosts
        for _ in range(30):
            ox = random.randint(
                -45,
                45
            )

            oy = random.randint(
                -20,
                20
            )

            color = random.choice([
                (255, 0, 60),
                (0, 255, 255),
                (255, 0, 255),
                (0, 100, 255),
            ])

            draw.text(
                (
                    center_x + ox,
                    center_y + oy
                ),
                text,
                fill=color,
                anchor="mm",
                font=self.font_big
            )

        draw.text(
            (
                center_x,
                center_y
            ),
            text,
            fill=WHITE,
            anchor="mm",
            font=self.font_big
        )

        draw.text(
            (
                center_x,
                center_y + 90
            ),
            "gdi_output.py > ?",
            fill=(0, 255, 100),
            anchor="mm",
            font=self.font_medium
        )

        return img

    # ==========================================================
    # RAINBOW
    # ==========================================================

    def rainbow(self):
        img = self.blank()

        draw = ImageDraw.Draw(img)

        for i in range(45):
            points = []

            base = (
                i *
                self.height /
                45
            )

            for x in range(
                0,
                self.width,
                25
            ):
                y = (
                    base
                    + math.sin(
                        x / 100
                        + self.frame / 8
                        + i / 3
                    ) * 100
                )

                points.append(
                    (x, y)
                )

            hue = (
                i / 45
                + self.frame * 0.01
            ) % 1

            r, g, b = colorsys.hsv_to_rgb(
                hue,
                1,
                1
            )

            draw.line(
                points,
                fill=(
                    int(r * 255),
                    int(g * 255),
                    int(b * 255)
                ),
                width=random.randint(
                    1,
                    5
                )
            )

        return img

    # ==========================================================
    # CHAOS
    # ==========================================================

    def chaos(self):
        img = self.capture_base()

        draw = ImageDraw.Draw(img)

        for _ in range(300):
            x = random.randint(
                0,
                self.width
            )

            y = random.randint(
                0,
                self.height
            )

            length = random.randint(
                5,
                250
            )

            color = self.random_rgb()

            if random.random() < 0.5:
                draw.line(
                    (
                        x,
                        y,
                        x + length,
                        y
                    ),
                    fill=color,
                    width=random.randint(
                        1,
                        8
                    )
                )
            else:
                draw.rectangle(
                    (
                        x,
                        y,
                        x + random.randint(
                            5,
                            100
                        ),
                        y + random.randint(
                            3,
                            40
                        )
                    ),
                    fill=color
                )

        # Glitch text
        for _ in range(12):
            draw.text(
                (
                    random.randint(
                        0,
                        max(
                            0,
                            self.width - 300
                        )
                    ),
                    random.randint(
                        0,
                        max(
                            0,
                            self.height - 40
                        )
                    )
                ),
                self.glitch_text(),
                fill=self.random_rgb(),
                font=self.font_small
            )

        return img


# ==============================================================
# ENTRY POINT
# ==============================================================

if __name__ == "__main__":
    try:
        app = FullyGDI()
        app.root.after(
            2700,
            app.tick
        )
        app.root.mainloop()

    except KeyboardInterrupt:
        pass
