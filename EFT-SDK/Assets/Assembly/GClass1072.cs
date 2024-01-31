using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000EF2 RID: 3826
public static class GClass1072
{
	// Token: 0x06004FE6 RID: 20454
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeFileHandle CreateFileW([MarshalAs(UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	// Token: 0x06004FE7 RID: 20455 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsSsd(string driveLetter)
	{
		throw null;
	}

	// Token: 0x04005CB0 RID: 23728
	private const int int_0 = 2954240;

	// Token: 0x04005CB1 RID: 23729
	private const uint uint_0 = 1U;

	// Token: 0x04005CB2 RID: 23730
	private const uint uint_1 = 2U;

	// Token: 0x04005CB3 RID: 23731
	private const uint uint_2 = 3U;

	// Token: 0x04005CB4 RID: 23732
	private const uint uint_3 = 128U;

	// Token: 0x02000EF3 RID: 3827
	public enum StoragePropertyId
	{
		// Token: 0x04005CB6 RID: 23734
		StorageDeviceProperty,
		// Token: 0x04005CB7 RID: 23735
		StorageAdapterProperty,
		// Token: 0x04005CB8 RID: 23736
		StorageDeviceIdProperty,
		// Token: 0x04005CB9 RID: 23737
		StorageDeviceUniqueIdProperty,
		// Token: 0x04005CBA RID: 23738
		StorageDeviceWriteCacheProperty,
		// Token: 0x04005CBB RID: 23739
		StorageMiniportProperty,
		// Token: 0x04005CBC RID: 23740
		StorageAccessAlignmentProperty,
		// Token: 0x04005CBD RID: 23741
		StorageDeviceSeekPenaltyProperty,
		// Token: 0x04005CBE RID: 23742
		StorageDeviceTrimProperty,
		// Token: 0x04005CBF RID: 23743
		StorageDeviceWriteAggregationProperty,
		// Token: 0x04005CC0 RID: 23744
		StorageDeviceDeviceTelemetryProperty,
		// Token: 0x04005CC1 RID: 23745
		StorageDeviceLBProvisioningProperty,
		// Token: 0x04005CC2 RID: 23746
		StorageDevicePowerProperty,
		// Token: 0x04005CC3 RID: 23747
		StorageDeviceCopyOffloadProperty,
		// Token: 0x04005CC4 RID: 23748
		StorageDeviceResiliencyProperty,
		// Token: 0x04005CC5 RID: 23749
		StorageDeviceMediumProductType,
		// Token: 0x04005CC6 RID: 23750
		StorageAdapterRpmbProperty,
		// Token: 0x04005CC7 RID: 23751
		StorageAdapterCryptoProperty,
		// Token: 0x04005CC8 RID: 23752
		StorageDeviceIoCapabilityProperty,
		// Token: 0x04005CC9 RID: 23753
		StorageAdapterProtocolSpecificProperty,
		// Token: 0x04005CCA RID: 23754
		StorageDeviceProtocolSpecificProperty,
		// Token: 0x04005CCB RID: 23755
		StorageAdapterTemperatureProperty,
		// Token: 0x04005CCC RID: 23756
		StorageDeviceTemperatureProperty,
		// Token: 0x04005CCD RID: 23757
		StorageAdapterPhysicalTopologyProperty,
		// Token: 0x04005CCE RID: 23758
		StorageDevicePhysicalTopologyProperty,
		// Token: 0x04005CCF RID: 23759
		StorageDeviceAttributesProperty,
		// Token: 0x04005CD0 RID: 23760
		StorageDeviceManagementStatus,
		// Token: 0x04005CD1 RID: 23761
		StorageAdapterSerialNumberProperty,
		// Token: 0x04005CD2 RID: 23762
		StorageDeviceLocationProperty,
		// Token: 0x04005CD3 RID: 23763
		StorageDeviceNumaProperty,
		// Token: 0x04005CD4 RID: 23764
		StorageDeviceZonedDeviceProperty,
		// Token: 0x04005CD5 RID: 23765
		StorageDeviceUnsafeShutdownCount
	}

	// Token: 0x02000EF4 RID: 3828
	public enum StorageQueryType
	{
		// Token: 0x04005CD7 RID: 23767
		PropertyStandardQuery,
		// Token: 0x04005CD8 RID: 23768
		PropertyExistsQuery,
		// Token: 0x04005CD9 RID: 23769
		PropertyMaskQuery,
		// Token: 0x04005CDA RID: 23770
		PropertyQueryMaxDefined
	}

	// Token: 0x02000EF5 RID: 3829
	[StructLayout(LayoutKind.Auto)]
	public struct Struct168
	{
		// Token: 0x04005CDB RID: 23771
		public int Version;

		// Token: 0x04005CDC RID: 23772
		public int Size;

		// Token: 0x04005CDD RID: 23773
		public bool IncursSeekPenalty;
	}

	// Token: 0x02000EF6 RID: 3830
	[StructLayout(LayoutKind.Auto)]
	public struct Struct169
	{
		// Token: 0x04005CDE RID: 23774
		public GClass1072.StoragePropertyId PropertyId;

		// Token: 0x04005CDF RID: 23775
		public GClass1072.StorageQueryType QueryType;

		// Token: 0x04005CE0 RID: 23776
		public byte AdditionalParameters;
	}
}
