﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeMessages.Helpers
{
    public interface IFileOps
    {
        string ConfigFilesPath { get; }

        Task TransferAssetsAsync(List<(string, string)> fileList);
    }
}