﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using Synology.Utilities;

namespace Synology.DownloadStation.Task
{
	[Flags]
	public enum TaskDetailsType
	{
		[Description("detail")]
		Detail = 1 << 0,
		[Description("transfer")]
		Transfer = 1 << 1,
		[Description("file")]
		File = 1 << 2,
		[Description("tracker")]
		Tracker = 1 << 3,
		[Description("peer")]
		Peer = 1 << 4
	}
}