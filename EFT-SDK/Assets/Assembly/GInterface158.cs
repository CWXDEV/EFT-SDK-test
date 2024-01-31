using System;
using System.Threading.Tasks;
using EFT;
using EFT.Hideout;

// Token: 0x02001A6B RID: 6763
public interface GInterface158
{
	// Token: 0x1700159E RID: 5534
	// (get) Token: 0x06008EC6 RID: 36550
	EAreaType AreaType { get; }

	// Token: 0x06008EC7 RID: 36551
	void Init(AreaTemplate areaTemplate);

	// Token: 0x06008EC8 RID: 36552
	Task<bool> PerformInteraction(ELightStatus status);
}
