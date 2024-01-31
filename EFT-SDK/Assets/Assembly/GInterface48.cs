using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

// Token: 0x02000D01 RID: 3329
public interface GInterface48
{
	// Token: 0x06004706 RID: 18182
	Task<T> Load<T>([NotNull] T settingsGroup) where T : GClass952<T>;

	// Token: 0x06004707 RID: 18183
	Task Save<T>([NotNull] T settingsGroup) where T : GClass952<T>;
}
