using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200238F RID: 9103
public static class TemplateIdToObjectMappingsClass
{
	// Token: 0x17001FD4 RID: 8148
	// (get) Token: 0x0600B761 RID: 46945 RVA: 0x00002050 File Offset: 0x00000250
	public static Dictionary<Type, string> BackwardTypeTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400BAE9 RID: 47849
	public static readonly Dictionary<string, Type> TypeTable;

	// Token: 0x0400BAEA RID: 47850
	public static readonly Dictionary<string, Type> CustomizationTypeTable;

	// Token: 0x0400BAEB RID: 47851
	public static readonly Dictionary<string, Type> TemplateTypeTable;

	// Token: 0x0400BAEC RID: 47852
	public static Dictionary<string, Func<string, object, Item>> ItemConstructors;

	// Token: 0x0400BAED RID: 47853
	private static Dictionary<Type, string> dictionary_0;

	// Token: 0x02002390 RID: 9104
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2020
	{
		// Token: 0x0600B762 RID: 46946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Type method_0(KeyValuePair<string, Type> x)
		{
			throw null;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(KeyValuePair<string, Type> x)
		{
			throw null;
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_2(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_3(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_4(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_5(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_6(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_7(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_8(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_9(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_10(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_11(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_12(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_13(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_14(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_15(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_16(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_17(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_18(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_19(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_20(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_21(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_22(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_23(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_24(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_25(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_26(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_27(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_28(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_29(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_30(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_31(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_32(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_33(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_34(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_35(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_36(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_37(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_38(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_39(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_40(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_41(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_42(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_43(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_44(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_45(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_46(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_47(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_48(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_49(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_50(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_51(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_52(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_53(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_54(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_55(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_56(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_57(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_58(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_59(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_60(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_61(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_62(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_63(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_64(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_65(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_66(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_67(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_68(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_69(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_70(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_71(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_72(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_73(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_74(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_75(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_76(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_77(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_78(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_79(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_80(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_81(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_82(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_83(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_84(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_85(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_86(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_87(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_88(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_89(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_90(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_91(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_92(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_93(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_94(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_95(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_96(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_97(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_98(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_99(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_100(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_101(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_102(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_103(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_104(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_105(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_106(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_107(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_108(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_109(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_110(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_111(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_112(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_113(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_114(string id, object template)
		{
			throw null;
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_115(string id, object template)
		{
			throw null;
		}

		// Token: 0x0400BAEE RID: 47854
		public static readonly TemplateIdToObjectMappingsClass.Class2020 class2020_0;

		// Token: 0x0400BAEF RID: 47855
		public static Func<KeyValuePair<string, Type>, Type> func_0;

		// Token: 0x0400BAF0 RID: 47856
		public static Func<KeyValuePair<string, Type>, string> func_1;
	}
}
