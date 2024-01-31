using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x02001BB5 RID: 7093
[JsonObject(MemberSerialization.OptIn)]
[StructLayout(LayoutKind.Auto)]
public struct GStruct241 : GInterface151
{
	// Token: 0x170016E8 RID: 5864
	// (get) Token: 0x06009506 RID: 38150 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009507 RID: 38151 RVA: 0x00002050 File Offset: 0x00000250
	public IExchangeRequirement[] Requirements
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170016E9 RID: 5865
	// (get) Token: 0x06009508 RID: 38152 RVA: 0x00002050 File Offset: 0x00000250
	public EMemberCategory MemberType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016EA RID: 5866
	// (get) Token: 0x06009509 RID: 38153 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentItemCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016EB RID: 5867
	// (get) Token: 0x0600950A RID: 38154 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600950B RID: 38155 RVA: 0x00002050 File Offset: 0x00000250
	public Item Item
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170016EC RID: 5868
	// (get) Token: 0x0600950C RID: 38156 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("id")]
	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016ED RID: 5869
	// (get) Token: 0x0600950D RID: 38157 RVA: 0x00002050 File Offset: 0x00000250
	public string TemplateId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016EE RID: 5870
	// (get) Token: 0x0600950E RID: 38158 RVA: 0x00002050 File Offset: 0x00000250
	public bool OnlyMoney
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016EF RID: 5871
	// (get) Token: 0x0600950F RID: 38159 RVA: 0x00002050 File Offset: 0x00000250
	public bool SellInOnePiece
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016F0 RID: 5872
	// (get) Token: 0x06009510 RID: 38160 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime EndTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170016F1 RID: 5873
	// (get) Token: 0x06009511 RID: 38161 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009512 RID: 38162 RVA: 0x00002050 File Offset: 0x00000250
	public int BuyRestrictionMax
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170016F2 RID: 5874
	// (get) Token: 0x06009513 RID: 38163 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009514 RID: 38164 RVA: 0x00002050 File Offset: 0x00000250
	public int BuyRestrictionCurrent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04009BC5 RID: 39877
	[CompilerGenerated]
	private IExchangeRequirement[] iexchangeRequirement_0;

	// Token: 0x04009BC6 RID: 39878
	[CompilerGenerated]
	private Item item_0;

	// Token: 0x04009BC7 RID: 39879
	[CompilerGenerated]
	private readonly bool bool_0;

	// Token: 0x04009BC8 RID: 39880
	[CompilerGenerated]
	private readonly bool bool_1;

	// Token: 0x04009BC9 RID: 39881
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04009BCA RID: 39882
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04009BCB RID: 39883
	[JsonProperty("count")]
	public int Count;

	// Token: 0x04009BCC RID: 39884
	public bool RemoveReferenceItem;

	// Token: 0x04009BCD RID: 39885
	[JsonIgnore]
	public bool IsTool;
}
