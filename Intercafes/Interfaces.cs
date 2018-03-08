using System;

namespace Intercafes
{
    /// <summary>
    /// (Actors from high level of achitecture)
    /// represents the interface to manipulate Person
    /// </summary>
    public interface IActor
    {
        Guid ActorID { get; set; }
        string ActorTitle { get; set; }
    }

    /// <summary>
    /// (Actor's prop)
    /// represent the interface to manipulate Document (actor's prop)
    /// </summary>
    public interface IActorProp
    {

        Guid ActorPropID { get; set; }
        string ActorPropTitle { get; set; }
        Guid ActorID { get; set; }
    }


    /// <summary>
    /// Dummy class
    /// </summary>
    public class Interfaces
    {

    }
}
