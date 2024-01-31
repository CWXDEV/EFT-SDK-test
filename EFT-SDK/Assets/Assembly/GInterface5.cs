using System;
using EFT;
using UnityEngine;

// Token: 0x0200032A RID: 810
public interface GInterface5
{
	// Token: 0x0600124C RID: 4684
	bool WantSuppress();

	// Token: 0x0600124D RID: 4685
	void SetWantSuppress();

	// Token: 0x0600124E RID: 4686
	void ReportEnemy(IPlayer enemy, Vector3 enemypos, EEnemyPartVisibleType visibleType);
}
