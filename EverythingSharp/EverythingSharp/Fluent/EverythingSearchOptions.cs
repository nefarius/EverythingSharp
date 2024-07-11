using System.Collections.Generic;

using EverythingSharp.Enums;

namespace EverythingSharp.Fluent
{
    public class EverythingSearchOptions
    {
        private readonly EverythingSearcher _searcher;

        internal EverythingSearchOptions(EverythingSearcher searcher)
        {
            _searcher = searcher;

            Sort = Sort.NameAscending;
            Flags = RequestFlags.FullPathAndFileName;
        }

        internal string Query { get; set; }
        internal uint? MaxResults { get; set; }
        internal uint? Offset { get; set; }
        internal Sort Sort { get; set; }
        internal RequestFlags Flags { get; set; }

        internal EverythingSearchOptions SetQuery(string query)
        {
            Query = query;
            return this;
        }

        public EverythingSearchOptions WithResultLimit(uint max)
        {
            MaxResults = max;
            return this;
        }

        public EverythingSearchOptions WithOffset(uint offset)
        {
            Offset = offset;
            return this;
        }

        public EverythingSearchOptions OrderBy(Sort sort)
        {
            Sort = sort;
            return this;
        }

        public EverythingSearchOptions GetFields(RequestFlags requestedFields)
        {
            Flags = requestedFields;
            return this;
        }

        public IEnumerable<EverythingEntry> Execute()
        {
            return _searcher.Execute(this);
        }
    }
}