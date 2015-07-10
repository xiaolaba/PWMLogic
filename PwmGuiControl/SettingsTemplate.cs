﻿/*
 * Copyright 2012 Joost Haverkort (BrrrBayBay)
 * http://brrrbaybay.com
 * 
 * 
 * This file is part of PwmLogic.
 * 
 * PwmLogic is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * PwmLogic is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even 
 * the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with PwmLogic. If not, see http://www.gnu.org/licenses/.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrrrBayBay.PwmGUIControl
{
	public class SettingsTemplate
	{

		public int SynchronousFrequency { get; set; }

		public String SynchronousFrequencyUnits { get; set; }

		public List<ChannelSettingsTemplate> ChannelSettings { get; set; }

		public SettingsTemplate()
		{
			SynchronousFrequency = 1000;
			SynchronousFrequencyUnits = "Hz";
			ChannelSettings = new List<ChannelSettingsTemplate>();
		}
	}
}
