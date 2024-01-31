using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

// Token: 0x02001E32 RID: 7730
public static class GClass2138
{
	// Token: 0x06009EAC RID: 40620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDriveTypeName(string directoryPath)
	{
		throw null;
	}

	// Token: 0x06009EAD RID: 40621
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeFileHandle CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	// Token: 0x06009EAE RID: 40622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint smethod_0(uint DeviceType, uint Function, uint Method, uint Access)
	{
		throw null;
	}

	// Token: 0x06009EAF RID: 40623
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl(SafeFileHandle hDevice, uint dwIoControlCode, ref GClass2138.Struct654 lpInBuffer, uint nInBufferSize, ref GClass2138.Struct655 lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

	// Token: 0x06009EB0 RID: 40624
	[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl_1(SafeFileHandle hDevice, uint dwIoControlCode, ref GClass2138.Struct657 lpInBuffer, uint nInBufferSize, ref GClass2138.Struct657 lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

	// Token: 0x06009EB1 RID: 40625
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint FormatMessage(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, uint nSize, IntPtr Arguments);

	// Token: 0x06009EB2 RID: 40626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_1(string sDrive)
	{
		throw null;
	}

	// Token: 0x06009EB3 RID: 40627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_2(string sDrive)
	{
		throw null;
	}

	// Token: 0x06009EB4 RID: 40628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_3(int code)
	{
		throw null;
	}

	// Token: 0x06009EB5 RID: 40629
	[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeviceIoControl_2(SafeFileHandle hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, ref GClass2138.Struct659 lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);

	// Token: 0x06009EB6 RID: 40630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint smethod_4(string cDrive)
	{
		throw null;
	}

	// Token: 0x0400A716 RID: 42774
	private const uint uint_0 = 2147483648U;

	// Token: 0x0400A717 RID: 42775
	private const uint uint_1 = 1073741824U;

	// Token: 0x0400A718 RID: 42776
	private const uint uint_2 = 1U;

	// Token: 0x0400A719 RID: 42777
	private const uint uint_3 = 2U;

	// Token: 0x0400A71A RID: 42778
	private const uint uint_4 = 3U;

	// Token: 0x0400A71B RID: 42779
	private const uint uint_5 = 128U;

	// Token: 0x0400A71C RID: 42780
	private const uint uint_6 = 45U;

	// Token: 0x0400A71D RID: 42781
	private const uint uint_7 = 45U;

	// Token: 0x0400A71E RID: 42782
	private const uint uint_8 = 4U;

	// Token: 0x0400A71F RID: 42783
	private const uint uint_9 = 4U;

	// Token: 0x0400A720 RID: 42784
	private const uint uint_10 = 0U;

	// Token: 0x0400A721 RID: 42785
	private const uint uint_11 = 0U;

	// Token: 0x0400A722 RID: 42786
	private const uint uint_12 = 1U;

	// Token: 0x0400A723 RID: 42787
	private const uint uint_13 = 2U;

	// Token: 0x0400A724 RID: 42788
	private const uint uint_14 = 86U;

	// Token: 0x0400A725 RID: 42789
	private const uint uint_15 = 7U;

	// Token: 0x0400A726 RID: 42790
	private const uint uint_16 = 0U;

	// Token: 0x0400A727 RID: 42791
	private const uint uint_17 = 2U;

	// Token: 0x0400A728 RID: 42792
	private const uint uint_18 = 4096U;

	// Token: 0x02001E33 RID: 7731
	[StructLayout(LayoutKind.Auto)]
	public struct Struct654
	{
		// Token: 0x0400A729 RID: 42793
		public uint PropertyId;

		// Token: 0x0400A72A RID: 42794
		public uint QueryType;

		// Token: 0x0400A72B RID: 42795
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public byte[] AdditionalParameters;
	}

	// Token: 0x02001E34 RID: 7732
	[StructLayout(LayoutKind.Auto)]
	public struct Struct655
	{
		// Token: 0x0400A72C RID: 42796
		public uint Version;

		// Token: 0x0400A72D RID: 42797
		public uint Size;

		// Token: 0x0400A72E RID: 42798
		[MarshalAs(UnmanagedType.U1)]
		public bool IncursSeekPenalty;
	}

	// Token: 0x02001E35 RID: 7733
	[StructLayout(LayoutKind.Auto)]
	public struct Struct656
	{
		// Token: 0x0400A72F RID: 42799
		public ushort Length;

		// Token: 0x0400A730 RID: 42800
		public ushort AtaFlags;

		// Token: 0x0400A731 RID: 42801
		public byte PathId;

		// Token: 0x0400A732 RID: 42802
		public byte TargetId;

		// Token: 0x0400A733 RID: 42803
		public byte Lun;

		// Token: 0x0400A734 RID: 42804
		public byte ReservedAsUchar;

		// Token: 0x0400A735 RID: 42805
		public uint DataTransferLength;

		// Token: 0x0400A736 RID: 42806
		public uint TimeOutValue;

		// Token: 0x0400A737 RID: 42807
		public uint ReservedAsUlong;

		// Token: 0x0400A738 RID: 42808
		public IntPtr DataBufferOffset;

		// Token: 0x0400A739 RID: 42809
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] PreviousTaskFile;

		// Token: 0x0400A73A RID: 42810
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] CurrentTaskFile;
	}

	// Token: 0x02001E36 RID: 7734
	[StructLayout(LayoutKind.Auto)]
	public struct Struct657
	{
		// Token: 0x0400A73B RID: 42811
		public GClass2138.Struct656 header;

		// Token: 0x0400A73C RID: 42812
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public ushort[] data;
	}

	// Token: 0x02001E37 RID: 7735
	[StructLayout(LayoutKind.Auto)]
	public struct Struct658
	{
		// Token: 0x0400A73D RID: 42813
		public uint DiskNumber;

		// Token: 0x0400A73E RID: 42814
		public long StartingOffset;

		// Token: 0x0400A73F RID: 42815
		public long ExtentLength;
	}

	// Token: 0x02001E38 RID: 7736
	[StructLayout(LayoutKind.Auto)]
	public struct Struct659
	{
		// Token: 0x0400A740 RID: 42816
		public uint NumberOfDiskExtents;

		// Token: 0x0400A741 RID: 42817
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public GClass2138.Struct658[] Extents;
	}
}
