using System;

namespace EFT.UI
{
	// Token: 0x02002C77 RID: 11383
	[Flags]
	public enum EValidationType
	{
		// Token: 0x0400E4CE RID: 58574
		Numbers = 1,
		// Token: 0x0400E4CF RID: 58575
		Latin = 2,
		// Token: 0x0400E4D0 RID: 58576
		AnyWordChars = 4,
		// Token: 0x0400E4D1 RID: 58577
		Space = 8,
		// Token: 0x0400E4D2 RID: 58578
		Hyphen = 16,
		// Token: 0x0400E4D3 RID: 58579
		Underscore = 32,
		// Token: 0x0400E4D4 RID: 58580
		Period = 64,
		// Token: 0x0400E4D5 RID: 58581
		Comma = 128,
		// Token: 0x0400E4D6 RID: 58582
		Slash = 256,
		// Token: 0x0400E4D7 RID: 58583
		Brackets = 512,
		// Token: 0x0400E4D8 RID: 58584
		Exclamation = 1024,
		// Token: 0x0400E4D9 RID: 58585
		Question = 2048,
		// Token: 0x0400E4DA RID: 58586
		Quotes = 4096,
		// Token: 0x0400E4DB RID: 58587
		At = 8192,
		// Token: 0x0400E4DC RID: 58588
		Colons = 16384,
		// Token: 0x0400E4DD RID: 58589
		Math = 33552,
		// Token: 0x0400E4DE RID: 58590
		Separator = 65536,
		// Token: 0x0400E4DF RID: 58591
		And = 131072,
		// Token: 0x0400E4E0 RID: 58592
		Dollar = 262144,
		// Token: 0x0400E4E1 RID: 58593
		NumSign = 524288,
		// Token: 0x0400E4E2 RID: 58594
		NewLine = 1048576,
		// Token: 0x0400E4E3 RID: 58595
		Everything = -1,
		// Token: 0x0400E4E4 RID: 58596
		NickName = 51,
		// Token: 0x0400E4E5 RID: 58597
		BuildName = 59,
		// Token: 0x0400E4E6 RID: 58598
		Punctuation = 23744,
		// Token: 0x0400E4E7 RID: 58599
		AllSymbols = 1048568,
		// Token: 0x0400E4E8 RID: 58600
		Notes = 2097151,
		// Token: 0x0400E4E9 RID: 58601
		SearchField = 1048573
	}
}
