using System;

namespace DPSProject.Domain.Models
{
    class LostAndFoundItem
    {
        public string Id { get; set; }

        public string ItemName { get; set; }

        public string ItemType { get; set; }

        public string FoundLocation { get; set; }

        public DateTime TimeFound { get; set; }

        public string FoundBy { get; set; }

        public string Description { get; set; }

        public string Dispostion { get; set; }

    }
}
