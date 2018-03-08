using System;
using AbstractClasses;

namespace ImplementationClasses
{
    public class ImplementationActorProp : AbstractActorProp
    {
        private Guid actorID;
         protected override Guid GetActorID()
        {
            return actorID;
        }

        private Guid actorPropID;
        protected override Guid GetActorPropID()
        {
            return actorPropID;
        }

        private string actorPropTitle;
        protected override string GetActorPropTitle()
        {
            return actorPropTitle;
        }

        protected override void SetActorID(Guid actorID)
        {
            this.actorID = actorID;
        }

        protected override void SetActorPropID(Guid actorPropID)
        {
            this.actorPropID = actorPropID;
        }

        protected override void SetActorPropTitle(string actorPropTitle)
        {
            this.actorPropTitle = actorPropTitle;
        }
    }


    public class ImplementationActor : AbstractActor
    {
        private Guid actorID;
        protected override Guid GetActorID()
        {
            return actorID;
        }

        private string actorTitle;
        protected override string GetActorTitle()
        {
            return actorTitle;
        }

        protected override void SetActorID(Guid ActorID)
        {
            this.actorID = ActorID;
        }

        protected override void SetActorTitle(string ActorTitle)
        {
            this.actorTitle = ActorTitle;
        }
    }
}
