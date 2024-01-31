using System;

// Token: 0x02001003 RID: 4099
public interface GInterface80
{
	// Token: 0x17000D65 RID: 3429
	// (get) Token: 0x0600556A RID: 21866
	// (set) Token: 0x0600556B RID: 21867
	float Value { get; set; }

	// Token: 0x0600556C RID: 21868
	string GetStringValue(string postfix = "");

	// Token: 0x0600556D RID: 21869
	string GetFullStringValue(string displayName);
}
