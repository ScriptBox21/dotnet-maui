﻿using System;
using System.Linq;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.ControlGallery.iOS;
using Microsoft.Maui.Controls.Compatibility.ControlGallery.Effects;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

[assembly: ExportEffect(typeof(AttachedStateEffectRenderer), AttachedStateEffect.EffectName)]
namespace Microsoft.Maui.Controls.Compatibility.ControlGallery.iOS
{
	public class AttachedStateEffectRenderer : PlatformEffect
	{
		public AttachedStateEffect MyEffect { get; private set; }

		protected override void OnAttached()
		{
			MyEffect = Element.Effects.OfType<AttachedStateEffect>().First();
			MyEffect.Attached(Element);

		}

		protected override void OnDetached()
		{
			MyEffect.Detached(Element);
		}
	}
}