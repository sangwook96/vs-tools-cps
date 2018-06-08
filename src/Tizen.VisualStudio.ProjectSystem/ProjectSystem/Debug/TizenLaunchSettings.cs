﻿/*
 * Copyright 2017 (c) Samsung Electronics Co., Ltd  All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * 	http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tizen.VisualStudio.ProjectSystem.Debug
{
    internal class TizenLaunchSettings : ITizenLaunchSettings
    {   
        public string Name { get; set; }

        [JsonProperty(PropertyName = Prop_ExtraArgs)]
        public string ExtraArguments { get; set; }
        
        const string Prop_ExtraArgs = "extraArgs";

        public static Dictionary<string, object> ToSerializableForm(ITizenLaunchSettings launchSettings)
        {
            var data = new Dictionary<string, object>(StringComparer.Ordinal);

            if (!string.IsNullOrEmpty(launchSettings.ExtraArguments))
            {
                data.Add(Prop_ExtraArgs, launchSettings.ExtraArguments);
            }

            return data;
        }

        public static TizenLaunchSettings DeserializeData(JObject launchObject)
        {
            TizenLaunchSettings tizenLaunchSettings = new TizenLaunchSettings();
            if (launchObject == null)
            {
                return tizenLaunchSettings;
            }

            tizenLaunchSettings = JsonConvert.DeserializeObject<TizenLaunchSettings>(launchObject.ToString());
            /*
            foreach (var setting in launchObject)
            {
                tizenLaunchSettings = JsonConvert.DeserializeObject<TizenLaunchSettings>(setting.ToString());
            }*/
            return tizenLaunchSettings;
        }
    }
}