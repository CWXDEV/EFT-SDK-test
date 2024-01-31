using System;

// Token: 0x0200319E RID: 12702
public interface GInterface397
{
	// Token: 0x17002B4E RID: 11086
	// (get) Token: 0x0600FA5A RID: 64090
	// (set) Token: 0x0600FA5B RID: 64091
	string Name { get; set; }

	// Token: 0x0600FA5C RID: 64092
	void CancelNameChange();

	// Token: 0x140003BB RID: 955
	// (add) Token: 0x0600FA5D RID: 64093
	// (remove) Token: 0x0600FA5E RID: 64094
	event Action<string, GInterface397> NameChanged;
}
