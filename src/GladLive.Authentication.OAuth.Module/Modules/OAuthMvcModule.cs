﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GladLive.Module.System.Library;
using Microsoft.Extensions.DependencyInjection;

namespace GladLive.Authentication.OAuth.Module
{
	public class OAuthMvcModule : MvcBuilderServiceRegistrationModule
	{
		public OAuthMvcModule(IMvcBuilder mvcBuilder) 
			: base(mvcBuilder)
		{

		}

		public override void Register()
		{
			//Register the modules controllers.
			mvcBuilderService.ConfigureApplicationPartManager(apm => apm.FeatureProviders.Add(new ControllerRegistry()));
		}
	}
}
