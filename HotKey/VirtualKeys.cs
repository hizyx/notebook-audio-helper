﻿using System;

namespace AudioHelper.HotKey
{
    /// <summary>
    /// 包含 Windows API 中的虚拟键代码常量的枚举。
    /// </summary>
    /// <seealso cref="https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes"/>
    public enum VirtualKeys : uint
    {
        None = 0X00,
        LeftButton = 0X01,
        RightButton = 0X02,
        Cancal = 0X03,
        MiddleButton = 0X04,
        XButton1 = 0X05,
        XButton2 = 0X06,
        // 0X07 is undefined.
        Back = 0x08,
        Tab = 0x09,
        // 0X0A 0X0B is reserved.
        Clear = 0x0C,
        Return = 0x0D,
        // 0X0E 0X0F is undefined.
        Shift = 0x10,
        Control = 0x11,
        Menu = 0x12,
        Pause = 0x13,
        CapsLock = 0x14,
        Kana = 0X15,
        Hangul = 0X15,
        // 0X16 is undefined.
        Junja = 0x17,
        Final = 0x18,
        Hanja = 0x19,
        Kanji = 0x19,
        // 0X1A is undefined.
        Escape = 0x1B,
        Convert = 0x1C,
        NonConvert = 0x1D,
        Accept = 0x1E,
        ModeChange = 0x1F,
        Space = 0x20,
        Prior = 0x21,
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        N0 = 0x30,
        N1 = 0x31,
        N2 = 0x32,
        N3 = 0x33,
        N4 = 0x34,
        N5 = 0x35,
        N6 = 0x36,
        N7 = 0x37,
        N8 = 0x38,
        N9 = 0x39,
        // 0X3A -0X40 is undefined.
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LeftWindows = 0x5B,
        RightWindows = 0x5C,
        Application = 0x5D,
        // 0X5E is Reserved.
        Sleep = 0x5F,
        Numpad0 = 0x60,
        Numpad1 = 0x61,
        Numpad2 = 0x62,
        Numpad3 = 0x63,
        Numpad4 = 0x64,
        Numpad5 = 0x65,
        Numpad6 = 0x66,
        Numpad7 = 0x67,
        Numpad8 = 0x68,
        Numpad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        // 0X88 - 0X8F is undefined.
        NumLock = 0x90,
        ScrollLock = 0x91,
        // 0X92 -0X96 is OEM specific.
        // 0X9 7-0X9F is unassigned.
        LeftShift = 0xA0,
        RightShift = 0xA1,
        LeftControl = 0xA2,
        RightControl = 0xA3,
        LeftMenu = 0xA4,
        RightMenu = 0xA5,
                     BrowserBack = 0xA6,
        BrowserForward = 0xA7,
        BrowserRefresh = 0xA8,
        BrowserStop = 0xA9,
        BrowserSearch = 0xAA,
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,
        VolumeMute = 0xAD,
        VolumeDown = 0xAE,
        VolumeUp = 0xAF,
        MediaNextTrack = 0xB0,
        MediaPrevTrack = 0xB1,
        MediaStop = 0xB2,
        MediaPlayPause = 0xB3,
        LaunchMail = 0xB4,
        LaunchMediaSelect = 0xB5,
        LaunchApplication1 = 0xB6,
        LaunchApplication2 = 0xB7,
        // 0XB8 -0XB9 is reserved.
        OEM1 = 0xBA,
        OEMPlus = 0xBB,
        OEMComma = 0xBC,
        OEMMinus = 0xBD,
        OEMPeriod = 0xBE,
        OEM2 = 0xBF,
        OEM3 = 0xC0,
        // 0XC1 -0XD7 is reserved.
        // 0XD8 - 0XDA is undefined.
        OEM4 = 0xDB,
        OEM5 = 0xDC,
        OEM6 = 0xDD,
        OEM7 = 0xDE,
        OEM8 = 0xDF,
        // 0XE0 is reserved.
        // 0XE1 is OEM specific.
                 OEM102 = 0xE2,
                 // 0XE3 -0XE4 is OEM specific.
                          ProcessKey = 0xE5,
                          // 0XE6 is OEM specific.
                                   Packet = 0xE7,
                                   // 0XE8 is undefined.
                                   // 0XE9 -0XF5 is OEM specific.
                                            ATTN = 0xF6,
                                                     CRSel = 0xF7,
                                                              EXSel = 0xF8,
                                                                       EREOF = 0xF9,
                                                                                Play = 0xFA,
                                                                                         Zoom = 0xFB,
                                                                                                  Noname = 0xFC,
                                                                                                           PA1 = 0xFD,
                                                                                                                    OEMClear = 0xFE
    }
}
