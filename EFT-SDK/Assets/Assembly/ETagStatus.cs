using System;

// Token: 0x02000746 RID: 1862
[Flags]
public enum ETagStatus
{
	// Token: 0x04002A6A RID: 10858
	Unaware = 1,
	// Token: 0x04002A6B RID: 10859
	Aware = 2,
	// Token: 0x04002A6C RID: 10860
	Combat = 4,
	// Token: 0x04002A6D RID: 10861
	Solo = 8,
	// Token: 0x04002A6E RID: 10862
	Coop = 16,
	// Token: 0x04002A6F RID: 10863
	Bear = 32,
	// Token: 0x04002A70 RID: 10864
	Usec = 64,
	// Token: 0x04002A71 RID: 10865
	Scav = 128,
	// Token: 0x04002A72 RID: 10866
	TargetSolo = 256,
	// Token: 0x04002A73 RID: 10867
	TargetMultiple = 512,
	// Token: 0x04002A74 RID: 10868
	Healthy = 1024,
	// Token: 0x04002A75 RID: 10869
	Injured = 2048,
	// Token: 0x04002A76 RID: 10870
	BadlyInjured = 4096,
	// Token: 0x04002A77 RID: 10871
	Dying = 8192,
	// Token: 0x04002A78 RID: 10872
	Birdeye = 16384,
	// Token: 0x04002A79 RID: 10873
	Knight = 32768,
	// Token: 0x04002A7A RID: 10874
	BigPipe = 65536
}
