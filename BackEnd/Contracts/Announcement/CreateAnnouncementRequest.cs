﻿using BackApi.DataTypes;

namespace BackEnd.Contracts.Announcement
{
    public class CreateAnnouncementRequest
    {
        public int ConsumerId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public AnnouncementStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
