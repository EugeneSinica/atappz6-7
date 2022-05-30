﻿namespace Entities
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Stars { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfFloors { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
