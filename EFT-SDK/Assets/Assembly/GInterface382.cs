using System;
using EFT.UI;

// Token: 0x02003095 RID: 12437
public interface GInterface382 : IDisposable, IUIView
{
	// Token: 0x170029DE RID: 10718
	// (get) Token: 0x0600F3DB RID: 62427
	GClass1248 Achievement { get; }

	// Token: 0x0600F3DC RID: 62428
	void Show(GClass1248 model, AbstractAchievementControllerClass achievementsController, NotesTaskDescriptionShort description, ISession session);
}
