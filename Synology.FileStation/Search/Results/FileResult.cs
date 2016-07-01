using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Synology.FileStation.Search.Results
{
	public class FileResult
	{
		public string Path { get; set; }

		public string Name { get; set; }

		public bool IsDir { get; set; }

		public IEnumerable<FileListResult> Children { get; set; }

		public FileAdditionalResult Additional { get; set; }
	}

}

