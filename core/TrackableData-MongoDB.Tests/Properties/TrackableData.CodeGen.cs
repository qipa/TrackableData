// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Akka.Interfaced CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using TrackableData.TestKits;
using Xunit;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using TrackableData;

#region ITestPocoForContainer

namespace TrackableData.MongoDB.Tests
{
    public partial class TrackableTestPocoForContainer : ITestPocoForContainer
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestPocoForContainer> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoForContainer>)value;
                Tracker = t;
            }
        }

        ITracker<ITestPocoForContainer> ITrackable<ITestPocoForContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoForContainer>)value;
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
            public static readonly PropertyInfo Name = typeof(ITestPocoForContainer).GetProperty("Name");
            public static readonly PropertyInfo Age = typeof(ITestPocoForContainer).GetProperty("Age");
            public static readonly PropertyInfo Extra = typeof(ITestPocoForContainer).GetProperty("Extra");
        }

        private string _Name;

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

        private int _Age;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(PropertyTable.Age, _Age, value);
                _Age = value;
            }
        }

        private int _Extra;

        public int Extra
        {
            get
            {
                return _Extra;
            }
            set
            {
                if (Tracker != null && Extra != value)
                    Tracker.TrackSet(PropertyTable.Extra, _Extra, value);
                _Extra = value;
            }
        }
    }
}

#endregion

#region ITestPoco

namespace TrackableData.MongoDB.Tests
{
    public partial class TrackableTestPoco : ITestPoco
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestPoco> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPoco>)value;
                Tracker = t;
            }
        }

        ITracker<ITestPoco> ITrackable<ITestPoco>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPoco>)value;
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
            public static readonly PropertyInfo Id = typeof(ITestPoco).GetProperty("Id");
            public static readonly PropertyInfo Name = typeof(ITestPoco).GetProperty("Name");
            public static readonly PropertyInfo Age = typeof(ITestPoco).GetProperty("Age");
            public static readonly PropertyInfo Extra = typeof(ITestPoco).GetProperty("Extra");
        }

        private ObjectId _Id;

        public ObjectId Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (Tracker != null && Id != value)
                    Tracker.TrackSet(PropertyTable.Id, _Id, value);
                _Id = value;
            }
        }

        private string _Name;

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

        private int _Age;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(PropertyTable.Age, _Age, value);
                _Age = value;
            }
        }

        private int _Extra;

        public int Extra
        {
            get
            {
                return _Extra;
            }
            set
            {
                if (Tracker != null && Extra != value)
                    Tracker.TrackSet(PropertyTable.Extra, _Extra, value);
                _Extra = value;
            }
        }
    }
}

#endregion

#region ITestPocoWithCustomId

namespace TrackableData.MongoDB.Tests
{
    public partial class TrackableTestPocoWithCustomId : ITestPocoWithCustomId
    {
        [IgnoreDataMember]
        public IPocoTracker<ITestPocoWithCustomId> Tracker { get; set; }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoWithCustomId>)value;
                Tracker = t;
            }
        }

        ITracker<ITestPocoWithCustomId> ITrackable<ITestPocoWithCustomId>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ITestPocoWithCustomId>)value;
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
            public static readonly PropertyInfo CustomId = typeof(ITestPocoWithCustomId).GetProperty("CustomId");
            public static readonly PropertyInfo Name = typeof(ITestPocoWithCustomId).GetProperty("Name");
            public static readonly PropertyInfo Age = typeof(ITestPocoWithCustomId).GetProperty("Age");
            public static readonly PropertyInfo Extra = typeof(ITestPocoWithCustomId).GetProperty("Extra");
        }

        private long _CustomId;

        public long CustomId
        {
            get
            {
                return _CustomId;
            }
            set
            {
                if (Tracker != null && CustomId != value)
                    Tracker.TrackSet(PropertyTable.CustomId, _CustomId, value);
                _CustomId = value;
            }
        }

        private string _Name;

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

        private int _Age;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (Tracker != null && Age != value)
                    Tracker.TrackSet(PropertyTable.Age, _Age, value);
                _Age = value;
            }
        }

        private int _Extra;

        public int Extra
        {
            get
            {
                return _Extra;
            }
            set
            {
                if (Tracker != null && Extra != value)
                    Tracker.TrackSet(PropertyTable.Extra, _Extra, value);
                _Extra = value;
            }
        }
    }
}

#endregion

#region ITestContainer

namespace TrackableData.MongoDB.Tests
{
    public partial class TrackableTestContainer : ITestContainer
    {
        [IgnoreDataMember]
        private TrackableTestContainerTracker _tracker;

        [IgnoreDataMember]
        public TrackableTestContainerTracker Tracker
        {
            get
            {
                return _tracker;
            }
            set
            {
                _tracker = value;
                Person.Tracker = value?.PersonTracker;
                Missions.Tracker = value?.MissionsTracker;
                Tags.Tracker = value?.TagsTracker;
            }
        }

        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        ITracker<ITestContainer> ITrackable<ITestContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        IContainerTracker<ITestContainer> ITrackableContainer<ITestContainer>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (TrackableTestContainerTracker)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                case "Person":
                    return Person as ITrackable;
                case "Missions":
                    return Missions as ITrackable;
                case "Tags":
                    return Tags as ITrackable;
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            var trackablePerson = Person as ITrackable;
            if (trackablePerson != null && (changedOnly == false || trackablePerson.Changed))
                yield return new KeyValuePair<object, ITrackable>("Person", trackablePerson);
            var trackableMissions = Missions as ITrackable;
            if (trackableMissions != null && (changedOnly == false || trackableMissions.Changed))
                yield return new KeyValuePair<object, ITrackable>("Missions", trackableMissions);
            var trackableTags = Tags as ITrackable;
            if (trackableTags != null && (changedOnly == false || trackableTags.Changed))
                yield return new KeyValuePair<object, ITrackable>("Tags", trackableTags);
        }

        private TrackableTestPocoForContainer _Person;

        public TrackableTestPocoForContainer Person
        {
            get
            {
                return _Person;
            }
            set
            {
                if (_Person != null)
                    _Person.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.PersonTracker;
                _Person = value;
            }
        }

        TrackableTestPocoForContainer ITestContainer.Person
        {
            get { return _Person; }
            set { _Person = (TrackableTestPocoForContainer)value; }
        }

        private TrackableDictionary<int, MissionData> _Missions;

        public TrackableDictionary<int, MissionData> Missions
        {
            get
            {
                return _Missions;
            }
            set
            {
                if (_Missions != null)
                    _Missions.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.MissionsTracker;
                _Missions = value;
            }
        }

        TrackableDictionary<int, MissionData> ITestContainer.Missions
        {
            get { return _Missions; }
            set { _Missions = (TrackableDictionary<int, MissionData>)value; }
        }

        private TrackableList<TagData> _Tags;

        public TrackableList<TagData> Tags
        {
            get
            {
                return _Tags;
            }
            set
            {
                if (_Tags != null)
                    _Tags.Tracker = null;
                if (value != null)
                    value.Tracker = Tracker?.TagsTracker;
                _Tags = value;
            }
        }

        TrackableList<TagData> ITestContainer.Tags
        {
            get { return _Tags; }
            set { _Tags = (TrackableList<TagData>)value; }
        }
    }

    public class TrackableTestContainerTracker : IContainerTracker<ITestContainer>
    {
        public TrackablePocoTracker<ITestPocoForContainer> PersonTracker { get; set; } = new TrackablePocoTracker<ITestPocoForContainer>();
        public TrackableDictionaryTracker<int, MissionData> MissionsTracker { get; set; } = new TrackableDictionaryTracker<int, MissionData>();
        public TrackableListTracker<TagData> TagsTracker { get; set; } = new TrackableListTracker<TagData>();

        public bool HasChange
        {
            get
            {
                return
                    PersonTracker.HasChange ||
                    MissionsTracker.HasChange ||
                    TagsTracker.HasChange ||
                    false;
            }
        }

        public void Clear()
        {
            PersonTracker.Clear();
            MissionsTracker.Clear();
            TagsTracker.Clear();
        }

        public void ApplyTo(object trackable)
        {
            ApplyTo((ITestContainer)trackable);
        }

        public void ApplyTo(ITestContainer trackable)
        {
            PersonTracker.ApplyTo(trackable.Person);
            MissionsTracker.ApplyTo(trackable.Missions);
            TagsTracker.ApplyTo(trackable.Tags);
        }

        public void ApplyTo(ITracker tracker)
        {
            ApplyTo((TrackableTestContainerTracker)tracker);
        }

        public void ApplyTo(ITracker<ITestContainer> tracker)
        {
            ApplyTo((TrackableTestContainerTracker)tracker);
        }

        public void ApplyTo(TrackableTestContainerTracker tracker)
        {
            PersonTracker.ApplyTo(tracker.PersonTracker);
            MissionsTracker.ApplyTo(tracker.MissionsTracker);
            TagsTracker.ApplyTo(tracker.TagsTracker);
        }

        public void RollbackTo(object trackable)
        {
            RollbackTo((ITestContainer)trackable);
        }

        public void RollbackTo(ITestContainer trackable)
        {
            PersonTracker.RollbackTo(trackable.Person);
            MissionsTracker.RollbackTo(trackable.Missions);
            TagsTracker.RollbackTo(trackable.Tags);
        }

        public void RollbackTo(ITracker tracker)
        {
            RollbackTo((TrackableTestContainerTracker)tracker);
        }

        public void RollbackTo(ITracker<ITestContainer> tracker)
        {
            RollbackTo((TrackableTestContainerTracker)tracker);
        }

        public void RollbackTo(TrackableTestContainerTracker tracker)
        {
            PersonTracker.RollbackTo(tracker.PersonTracker);
            MissionsTracker.RollbackTo(tracker.MissionsTracker);
            TagsTracker.RollbackTo(tracker.TagsTracker);
        }
    }
}

#endregion
