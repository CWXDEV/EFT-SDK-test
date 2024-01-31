using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Settings
{
	// Token: 0x02002D5D RID: 11613
	public abstract class SettingsTab : UIElement
	{
		// Token: 0x1400032E RID: 814
		// (add) Token: 0x0600E473 RID: 58483 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E474 RID: 58484 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnLoadingInProgress
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170027CC RID: 10188
		// (set) Token: 0x0600E475 RID: 58485 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600E476 RID: 58486
		public abstract Task TakeSettingsFrom(SharedGameSettingsClass settingsManager);

		// Token: 0x0600E477 RID: 58487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnTabSelected()
		{
			throw null;
		}

		// Token: 0x0600E478 RID: 58488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected T CreateControl<T>(T prefab, Transform parent) where T : SettingControl
		{
			throw null;
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetLoadingStatus(bool inProgress)
		{
			throw null;
		}

		// Token: 0x0600E47B RID: 58491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterDropDown(DropDownBox dropDownBox)
		{
			throw null;
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Replace this with SettingDropDown")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowEnumDropDown<T>(DropDownBox dropdown, GameSetting<T> setting, string localizationPrefix = null, Action valueChanged = null) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Replace this with SettingSelectSlider")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void BindSelectSliderToSetting<T>(SelectSlider slider, GameSetting<T> setting, ReadOnlyCollection<T> variants, Func<T, string> stringConverter, Action valueChanged = null)
		{
			throw null;
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowFakeSlider(SelectSlider selectSlider)
		{
			throw null;
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Replace this with SettingFloatSlider")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void BindFloatSliderToSetting(FloatSlider slider, GameSetting<int> setting, float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Replace this with SettingFloatSlider")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void BindFloatSliderToSetting(FloatSlider slider, GameSetting<float> setting, float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x0600E481 RID: 58497 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Replace this with SettingToggle")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void BindToggleToSetting(UpdatableToggle toggle, GameSetting<bool> setting, Action valueChanged = null)
		{
			throw null;
		}

		// Token: 0x0600E482 RID: 58498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void ShowFakeToggle(UpdatableToggle toggle)
		{
			throw null;
		}

		// Token: 0x0400E98A RID: 59786
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0400E98B RID: 59787
		private static readonly string[] string_0;

		// Token: 0x0400E98C RID: 59788
		private List<SettingControl> list_0;

		// Token: 0x02002D5E RID: 11614
		[Obsolete("Replace this with UiElementBlocker")]
		[Serializable]
		protected struct ElementBlocker
		{
			// Token: 0x0600E483 RID: 58499 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartBlock(string reason = null)
			{
				throw null;
			}

			// Token: 0x0600E484 RID: 58500 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveBlock()
			{
				throw null;
			}

			// Token: 0x0400E98D RID: 59789
			public Graphic Graphic;

			// Token: 0x0400E98E RID: 59790
			public CanvasGroup Group;

			// Token: 0x0400E98F RID: 59791
			public HoverTooltipArea Tooltip;
		}

		// Token: 0x02002D5F RID: 11615
		[CompilerGenerated]
		private sealed class Class2797<T> where T : struct, Enum
		{
			// Token: 0x0600E485 RID: 58501 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_0()
			{
				throw null;
			}

			// Token: 0x0600E486 RID: 58502 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(string x)
			{
				throw null;
			}

			// Token: 0x0600E487 RID: 58503 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(int index)
			{
				throw null;
			}

			// Token: 0x0400E990 RID: 59792
			public string localizationPrefix;

			// Token: 0x0400E991 RID: 59793
			public GameSetting<T> setting;

			// Token: 0x0400E992 RID: 59794
			public Action valueChanged;

			// Token: 0x0400E993 RID: 59795
			public Func<string, string> func_0;
		}

		// Token: 0x02002D60 RID: 11616
		[CompilerGenerated]
		private sealed class Class2798<T>
		{
			// Token: 0x0600E488 RID: 58504 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0400E994 RID: 59796
			public GameSetting<T> setting;

			// Token: 0x0400E995 RID: 59797
			public ReadOnlyCollection<T> variants;

			// Token: 0x0400E996 RID: 59798
			public Action valueChanged;
		}

		// Token: 0x02002D61 RID: 11617
		[CompilerGenerated]
		private sealed class Class2799
		{
			// Token: 0x0600E489 RID: 58505 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float value)
			{
				throw null;
			}

			// Token: 0x0400E997 RID: 59799
			public GameSetting<int> setting;
		}

		// Token: 0x02002D62 RID: 11618
		[CompilerGenerated]
		private sealed class Class2800
		{
			// Token: 0x0600E48A RID: 58506 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float value)
			{
				throw null;
			}

			// Token: 0x0400E998 RID: 59800
			public GameSetting<float> setting;
		}

		// Token: 0x02002D63 RID: 11619
		[CompilerGenerated]
		private sealed class Class2801
		{
			// Token: 0x0600E48B RID: 58507 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg)
			{
				throw null;
			}

			// Token: 0x0400E999 RID: 59801
			public GameSetting<bool> setting;

			// Token: 0x0400E99A RID: 59802
			public Action valueChanged;
		}
	}
}
