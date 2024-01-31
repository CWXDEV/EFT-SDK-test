using System;
using System.ComponentModel;
using Newtonsoft.Json;

// Token: 0x02000FC6 RID: 4038
public class QuestItemClass
{
	// Token: 0x04006089 RID: 24713
	public string _id;

	// Token: 0x0400608A RID: 24714
	public string _tpl;

	// Token: 0x0400608B RID: 24715
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	[DefaultValue(null)]
	public string parentId;
}
