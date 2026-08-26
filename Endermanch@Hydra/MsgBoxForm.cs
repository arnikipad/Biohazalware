// Decompiled with JetBrains decompiler
// Type: Hydra.MsgBoxForm
// Assembly: Hydra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FE967A65-D44D-4D25-B3F9-59D325AB8DF5
// Assembly location: \\VBOXSVR\B4s3\ToxicDatabase-main\BadJoke\Endermanch@Hydra\Endermanch@Hydra.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace Hydra;

public class MsgBoxForm : Form
{
  public bool IsStartupForm;
  public bool BtnPressed;
  private IContainer components;
  private PictureBox pbIcon;
  private Label lblText;
  private Button btnOk;

  public MsgBoxForm() => this.InitializeComponent();

  private void MsgBoxForm_Load(object sender, EventArgs e)
  {
    try
    {
      this.Location = new Point(Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width), Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height));
      byte num = Program.TextInsanity();
      if (num > (byte) 4)
        num = (byte) 4;
      if (num == (byte) 0)
        this.lblText.Text = "Cut off a head, two more will take its place.\n[Hydra ViRuS BioCoded by WiPet]";
      if (num == (byte) 1)
      {
        for (int index = 0; index < (int) Program.textLength; ++index)
          this.lblText.Text += ((char) Program.rand.Next(32 /*0x20*/, (int) sbyte.MaxValue)).ToString();
      }
      if (num == (byte) 2)
        new Thread((ThreadStart) (async () =>
        {
          while (true)
          {
            try
            {
              this.lblText.Invoke((Delegate) (() =>
              {
                try
                {
                  this.lblText.Text = "";
                }
                catch
                {
                }
              }));
              for (int index = 0; index < (int) Program.textLength; ++index)
                this.lblText.Invoke((Delegate) (() =>
                {
                  try
                  {
                    this.lblText.Text += ((char) Program.rand.Next(0, 256 /*0x0100*/)).ToString();
                  }
                  catch
                  {
                  }
                }));
              this.lblText.Invoke((Delegate) (() =>
              {
                try
                {
                  this.lblText.Font = new Font(this.lblText.Font.FontFamily, (float) (Program.rand.NextDouble() * 2.0 - Program.rand.NextDouble() * 2.0) + this.lblText.Font.Size);
                }
                catch
                {
                }
              }));
            }
            catch
            {
            }
            await Task.Delay(Program.rand.Next(1000, 5001));
          }
        })).Start();
      if (num >= (byte) 2)
        new Thread((ThreadStart) (async () =>
        {
          while (true)
          {
            try
            {
              this.lblText.Invoke((Delegate) (() =>
              {
                try
                {
                  this.lblText.Text = "";
                  this.lblText.Font = new Font(this.lblText.Font.FontFamily, (float) (Program.rand.NextDouble() * 20.0));
                }
                catch
                {
                }
              }));
              for (int index = 0; index < (int) Program.textLength; ++index)
                this.lblText.Invoke((Delegate) (() =>
                {
                  try
                  {
                    this.lblText.Text += ((char) Program.rand.Next(0, (int) ushort.MaxValue)).ToString();
                  }
                  catch
                  {
                  }
                }));
            }
            catch
            {
            }
            await Task.Delay(Program.rand.Next(1000, 5001));
          }
        })).Start();
      if (num == (byte) 3)
        new Thread((ThreadStart) (async () =>
        {
          while (true)
          {
            try
            {
              this.Invoke((Delegate) (() =>
              {
                try
                {
                  this.Location = new Point(Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Width - this.Width), Program.rand.Next(0, Screen.PrimaryScreen.Bounds.Height - this.Height));
                }
                catch
                {
                }
              }));
            }
            catch
            {
            }
            await Task.Delay(Program.rand.Next(1000, 5001));
          }
        })).Start();
      if (num == (byte) 4)
        new Thread((ThreadStart) (async () =>
        {
          while (true)
          {
            try
            {
              this.Invoke((Delegate) (() =>
              {
                try
                {
                  this.BringToFront();
                }
                catch
                {
                }
              }));
            }
            catch
            {
            }
            await Task.Delay(Program.rand.Next(1000, 5001));
          }
        })).Start();
      try
      {
        Program.textLength += (short) 2;
      }
      catch
      {
      }
      this.Opacity = 1.0;
    }
    catch
    {
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (!this.IsStartupForm)
    {
      this.Close();
    }
    else
    {
      this.MsgBoxForm_FormClosing((object) null, (FormClosingEventArgs) null);
      this.Hide();
    }
  }

  private void MsgBoxForm_KeyPress(object sender, KeyPressEventArgs e)
  {
    if (e.KeyChar != '\r' || !this.btnOk.Enabled)
      return;
    this.btnOk_Click((object) null, (EventArgs) null);
  }

  private void MsgBoxForm_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      new MsgBoxForm().Show();
      new MsgBoxForm().Show();
      if (!this.IsStartupForm)
        return;
      this.Hide();
      e.Cancel = true;
    }
    catch
    {
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MsgBoxForm));
    this.lblText = new Label();
    this.btnOk = new Button();
    this.pbIcon = new PictureBox();
    ((ISupportInitialize) this.pbIcon).BeginInit();
    this.SuspendLayout();
    this.lblText.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblText.Location = new Point(82, 12);
    this.lblText.Name = "lblText";
    this.lblText.Size = new Size(376, 117);
    this.lblText.TabIndex = 1;
    this.btnOk.Location = new Point(383, 143);
    this.btnOk.Name = "btnOk";
    this.btnOk.Size = new Size(75, 23);
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "OK";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnOk.Click += new EventHandler(this.btnOk_Click);
    this.pbIcon.Image = (Image) componentResourceManager.GetObject("pbIcon.Image");
    this.pbIcon.Location = new Point(12, 12);
    this.pbIcon.Name = "pbIcon";
    this.pbIcon.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbIcon.TabIndex = 0;
    this.pbIcon.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(470, 178);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.lblText);
    this.Controls.Add((Control) this.pbIcon);
    this.FormBorderStyle = FormBorderStyle.Fixed3D;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (MsgBoxForm);
    this.Opacity = 0.0;
    this.ShowIcon = false;
    this.Text = "HYDRA";
    this.TopMost = true;
    this.FormClosing += new FormClosingEventHandler(this.MsgBoxForm_FormClosing);
    this.Load += new EventHandler(this.MsgBoxForm_Load);
    this.KeyPress += new KeyPressEventHandler(this.MsgBoxForm_KeyPress);
    ((ISupportInitialize) this.pbIcon).EndInit();
    this.ResumeLayout(false);
  }
}
