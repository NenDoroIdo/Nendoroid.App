using System;
using System.Collections.Generic;
using System.Text;
using NendoroidAccessorySearchEngine.Core.Model;

namespace Form.Model.Search.Result
{
    /// <summary>
    /// Search result
    /// </summary>
    public class SearchResultModel
    {
        /// <summary>
        /// spend time
        /// </summary>
        public float TimeSpend { get; set; }

        /// <summary>
        /// list result
        /// </summary>
        public List<SearchResult> ListMatchResult { get; set; }
    }
}
