﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TrackableData.MySql;
using TrackableData.TestKits;
using Xunit;

namespace TrackableData.MySql.Tests
{
    public class TrackableDictionaryStringTest : StorageDictionaryValueTestKit<int>, IClassFixture<Database>, IDisposable
    {
        private static readonly ColumnDefinition SingleValueColumnDef = new ColumnDefinition("Value", typeof(string));

        private static TrackableDictionaryMySqlMapper<int, string> _mapper = 
            new TrackableDictionaryMySqlMapper<int, string>(
                nameof(TrackableDictionaryStringTest), new ColumnDefinition("Id"), SingleValueColumnDef, null);

        private Database _db;
        private MySqlConnection _connection;

        public TrackableDictionaryStringTest(Database db)
        {
            _db = db;
            _connection = db.Connection;
            _mapper.ResetTableAsync(_connection).Wait();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        protected override int CreateKey(int value)
        {
            return value;
        }

        protected override Task CreateAsync(IDictionary<int, string> dictionary)
        {
            return _mapper.CreateAsync(_connection, dictionary);
        }

        protected override Task<int> DeleteAsync()
        {
            return _mapper.DeleteAsync(_connection);
        }

        protected override Task<TrackableDictionary<int, string>> LoadAsync()
        {
            return _mapper.LoadAsync(_connection);
        }

        protected override Task SaveAsync(ITracker tracker)
        {
            return _mapper.SaveAsync(_connection, (TrackableDictionaryTracker<int, string>)tracker);
        }
    }

    public class TrackableDictionaryDataTest : StorageDictionaryDataTestKit<int>, IClassFixture<Database>, IDisposable
    {
        private static TrackableDictionaryMySqlMapper<int, ItemData> _mapper =
            new TrackableDictionaryMySqlMapper<int, ItemData>(
                nameof(TrackableDictionaryDataTest), new ColumnDefinition("Id"));

        private Database _db;
        private MySqlConnection _connection;

        public TrackableDictionaryDataTest(Database db)
        {
            _db = db;
            _connection = db.Connection;
            _mapper.ResetTableAsync(_connection).Wait();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        protected override int CreateKey(int value)
        {
            return value;
        }

        protected override Task CreateAsync(IDictionary<int, ItemData> dictionary)
        {
            return _mapper.CreateAsync(_connection, dictionary);
        }

        protected override Task<int> DeleteAsync()
        {
            return _mapper.DeleteAsync(_connection);
        }

        protected override Task<TrackableDictionary<int, ItemData>> LoadAsync()
        {
            return _mapper.LoadAsync(_connection);
        }

        protected override Task SaveAsync(ITracker tracker)
        {
            return _mapper.SaveAsync(_connection, (TrackableDictionaryTracker<int, ItemData>)tracker);
        }
    }

    public class TrackableDictionaryDataWithHeadKeysTest : StorageDictionaryDataTestKit<int>, IClassFixture<Database>, IDisposable
    {
        private static readonly ColumnDefinition[] HeadKeyColumnDefs =
        {
            new ColumnDefinition("Head1", typeof(int)),
            new ColumnDefinition("Head2", typeof(string), 100)
        };
        private static TrackableDictionaryMySqlMapper<int, ItemData> _mapper =
            new TrackableDictionaryMySqlMapper<int, ItemData>(
                nameof(TrackableDictionaryDataWithHeadKeysTest), new ColumnDefinition("Id"), HeadKeyColumnDefs);

        private Database _db;
        private MySqlConnection _connection;

        public TrackableDictionaryDataWithHeadKeysTest(Database db)
        {
            _db = db;
            _connection = db.Connection;
            _mapper.ResetTableAsync(_connection).Wait();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }

        protected override int CreateKey(int value)
        {
            return value;
        }

        protected override Task CreateAsync(IDictionary<int, ItemData> dictionary)
        {
            return _mapper.CreateAsync(_connection, dictionary, 1, "One");
        }

        protected override Task<int> DeleteAsync()
        {
            return _mapper.DeleteAsync(_connection, 1, "One");
        }

        protected override Task<TrackableDictionary<int, ItemData>> LoadAsync()
        {
            return _mapper.LoadAsync(_connection, 1, "One");
        }

        protected override Task SaveAsync(ITracker tracker)
        {
            return _mapper.SaveAsync(_connection, (TrackableDictionaryTracker<int, ItemData>)tracker, 1, "One");
        }
    }
}