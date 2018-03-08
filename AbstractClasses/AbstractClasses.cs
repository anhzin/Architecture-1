using System;
using Intercafes;

namespace AbstractClasses
{
    public abstract class AbstractActorProp : IActorProp
    {
       
        /// <summary>
        /// Document property with hiden geter and setter.
        /// It may be very usefull to implement complex logic in method.
        /// </summary>
        public Guid ActorID { get => GetActorID(); set => SetActorID(value); }
        protected abstract void SetActorID(Guid ActorID);
        protected abstract Guid GetActorID();
        
        public Guid ActorPropID { get => GetActorPropID(); set => SetActorPropID(value); }
        protected abstract void SetActorPropID(Guid ActorPropID);
        protected abstract Guid GetActorPropID();

        public string ActorPropTitle { get => GetActorPropTitle(); set => SetActorPropTitle(value); }
        protected abstract void SetActorPropTitle(string ActorPropTitle);
        protected abstract string GetActorPropTitle();

    }

    public abstract class AbstractActor : IActor
    {
        public Guid ActorID { get => GetActorID(); set => SetActorID(value); }
        protected abstract void SetActorID(Guid ActorID);
        protected abstract Guid GetActorID();

        public string ActorTitle { get => GetActorTitle(); set => SetActorTitle(value); }
        protected abstract void SetActorTitle(string ActorTitle);
        protected abstract string GetActorTitle();
    }

}
