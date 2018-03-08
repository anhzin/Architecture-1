using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImplementationClasses;

namespace SoftwareAPI.Models
{
    public class Document : ImplementationActorProp
    {
        public Guid PersonID { get => base.ActorID; set => base.ActorID = value; }
        public Guid ID { get => base.ActorPropID; set => base.ActorPropID = value; }
        public string Title { get => base.ActorPropTitle; set => base.ActorPropTitle = value; }
    }
}