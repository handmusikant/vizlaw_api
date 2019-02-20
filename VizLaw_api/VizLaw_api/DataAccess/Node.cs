﻿namespace VizLaw_api.DataAccess
{
    public class Node
    {

        public string NodeId { get ; set; }
        public string Name { get; set; }

        public string Date { get; set; }

        public string Court { get; set; }
        public string numberCitations { get; set; }

        public Node(string nodid, string name, string date, string court, string numbercitations)
        {
            NodeId = nodid;
            Name = name;
            Date = date;
            Court = court;
            numberCitations = numbercitations;
        }

    }
}