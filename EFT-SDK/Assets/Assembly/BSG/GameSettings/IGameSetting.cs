using System;
using Newtonsoft.Json;

namespace Bsg.GameSettings
{
	// Token: 0x02000CF0 RID: 3312
	[JsonConverter(typeof(GClass962))]
	public interface IGameSetting
	{
		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060046B3 RID: 18099
		string Key { get; }

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060046B4 RID: 18100
		// (set) Token: 0x060046B5 RID: 18101
		bool IsAvailableToEdit { get; set; }

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060046B6 RID: 18102
		// (set) Token: 0x060046B7 RID: 18103
		object ObjectValue { get; set; }

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060046B8 RID: 18104
		Type ObjectType { get; }

		// Token: 0x060046B9 RID: 18105
		bool HasSameValue(IGameSetting other);

		// Token: 0x060046BA RID: 18106
		void TakeValueFrom(IGameSetting other);

		// Token: 0x060046BB RID: 18107
		void ForceApply();
	}
}
