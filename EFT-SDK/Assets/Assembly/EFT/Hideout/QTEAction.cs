using System;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BF0 RID: 7152
	public abstract class QTEAction : MonoBehaviour
	{
		// Token: 0x06009650 RID: 38480
		public abstract Task<bool> StartAction(QuickTimeEvent quickTimeEvent);
	}
}
