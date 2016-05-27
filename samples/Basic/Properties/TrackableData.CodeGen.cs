﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by TrackableData.CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using TrackableData;
using ProtoBuf;

#region IUserData

namespace Basic
{
    [ProtoContract]
    public partial class TrackableUserData : IUserData
    {
        [IgnoreDataMember]
        public IPocoTracker<IUserData> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<IUserData>)value;
                Tracker = t;
            }
        }

        ITracker<IUserData> ITrackable<IUserData>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<IUserData>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo Name = typeof(IUserData).GetProperty("Name");
            public static readonly PropertyInfo Gold = typeof(IUserData).GetProperty("Gold");
            public static readonly PropertyInfo Level = typeof(IUserData).GetProperty("Level");
        }

        private string _Name;

        [ProtoMember(1)] 
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Tracker != null && Name != value)
                    Tracker.TrackSet(PropertyTable.Name, _Name, value);
                _Name = value;
            }
        }

        private int _Gold;

        [ProtoMember(2)] 
        public int Gold
        {
            get
            {
                return _Gold;
            }
            set
            {
                if (Tracker != null && Gold != value)
                    Tracker.TrackSet(PropertyTable.Gold, _Gold, value);
                _Gold = value;
            }
        }

        private int _Level;

        [ProtoMember(3)] 
        public int Level
        {
            get
            {
                return _Level;
            }
            set
            {
                if (Tracker != null && Level != value)
                    Tracker.TrackSet(PropertyTable.Level, _Level, value);
                _Level = value;
            }
        }
    }

    [ProtoContract]
    public class TrackableUserDataTrackerSurrogate
    {
        [ProtoMember(1)] public EnvelopedObject<string> Name;
        [ProtoMember(2)] public EnvelopedObject<int> Gold;
        [ProtoMember(3)] public EnvelopedObject<int> Level;

        [ProtoConverter]
        public static TrackableUserDataTrackerSurrogate Convert(TrackablePocoTracker<IUserData> tracker)
        {
            if (tracker == null)
                return null;

            var surrogate = new TrackableUserDataTrackerSurrogate();
            foreach(var changeItem in tracker.ChangeMap)
            {
                switch (changeItem.Key.Name)
                {
                    case "Name":
                        surrogate.Name = new EnvelopedObject<string> { Value = (string)changeItem.Value.NewValue };
                        break;
                    case "Gold":
                        surrogate.Gold = new EnvelopedObject<int> { Value = (int)changeItem.Value.NewValue };
                        break;
                    case "Level":
                        surrogate.Level = new EnvelopedObject<int> { Value = (int)changeItem.Value.NewValue };
                        break;
                }
            }

            return surrogate;
        }

        [ProtoConverter]
        public static TrackablePocoTracker<IUserData> Convert(TrackableUserDataTrackerSurrogate surrogate)
        {
            if (surrogate == null)
                return null;

            var tracker = new TrackablePocoTracker<IUserData>();
            if (surrogate.Name != null)
                tracker.ChangeMap.Add(TrackableUserData.PropertyTable.Name, new TrackablePocoTracker<IUserData>.Change { NewValue = surrogate.Name.Value });
            if (surrogate.Gold != null)
                tracker.ChangeMap.Add(TrackableUserData.PropertyTable.Gold, new TrackablePocoTracker<IUserData>.Change { NewValue = surrogate.Gold.Value });
            if (surrogate.Level != null)
                tracker.ChangeMap.Add(TrackableUserData.PropertyTable.Level, new TrackablePocoTracker<IUserData>.Change { NewValue = surrogate.Level.Value });
            return tracker;
        }
    }
}

#endregion
