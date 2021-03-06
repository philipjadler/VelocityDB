﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VelocityDb;
using VelocityDb.Collection;
using VelocityDb.Collection.BTree;
using VelocityDb.Session;
using VelocityDb.TypeInfo;

namespace VelocityDbSchema.Samples.AllSupportedSample
{
  public class AllSuportedSub1 : OptimizedPersistable
  {
    Pet aPet;
    [UseOidShort]
    List<Pet> _petListOidShort;
    public Type[] m_type;
    public AllSuportedSub1(Int32 arraySize)
    {
      _petListOidShort = new List<Pet>(arraySize);
      aPet = new Cat("Boze", 5);
      _petListOidShort.Add(aPet);
      m_type = new Type[5];
      m_type[0] = typeof(Pet);
      m_type[1] = typeof(AllSuportedSub1);
      m_type[3] = typeof(OptimizedPersistable);
    }

    public List<Pet> PetListOidShort
    {
      get
      {
        return _petListOidShort;
      }
    }
  }

  public class AllSuportedSub2 : OptimizedPersistable
  {
    [UseOidShort]
    Person[] personArrayOidShort;
    public AllSuportedSub2(Int32 arraySize)
    {
      personArrayOidShort = new Person[arraySize];
      personArrayOidShort[1] = new Person();
      personArrayOidShort[0] = null;
    }
  }

  public class AllSuportedSub3 : OptimizedPersistable
  {
    [UseOidShort]
    List<Person> personListShort;
    public AllSuportedSub3(Int32 arraySize)
    {
      personListShort = new List<Person>(arraySize);
      personListShort.Add(null);
      personListShort.Add(null);
      personListShort.Add(new Person());
    }
  }

  public class AllSuportedSub4 : OptimizedPersistable
  {
    int[,] array = new int[4, 2];
    int[,,] array2 = new int[4, 2, 3];
    public AllSuportedSub4()
    {
      array[0, 1] = 9;
      array2[0, 1, 2] = 9;
    }
  }
  public interface IAllSuportedSub : IOptimizedPersistable
  {
  }

  public class AllSuportedSub5 : OptimizedPersistable, IAllSuportedSub
  {
    public double? nullableaDouble = null;
    public AllSuportedSub5()
    {     
    }
  }

  public class AllSuportedSub6 : OptimizedPersistable
  {
    IAllSuportedSub _myInterface;
    AllSuportedSub5 _sub5;
    public AllSuportedSub6()
    {
      _sub5 = new AllSuportedSub5();
      _myInterface = _sub5;
    }
  }

  public interface ISomeStuff
  {
    List<Int16> Int16List { get; }
  }

  public class AllSupported : OptimizedPersistable, ISomeStuff
  {
    public enum ByteEnum : byte { a, b, c };
    public enum Int16Enum : short { a, b, c, d, e, f };
    public enum Int32Enum : int { a, b, c, d, e, f, g, h };
    public enum Int64Enum : long { a, b, c, dd, ee, ff };
    public enum UInt64Enum : ulong { a, b, c, dd, ee, ff };
    UInt64Enum[] _uint64EnumArray;
    ISomeStuff m_objectInterface;
    List<Int16Enum> enum16list;
    int[][] jaggedArray = new int[3][];
    Person person;
    object m_object;
    public WeakIOptimizedPersistableReference<IOptimizedPersistable>[] m_weakRefArray;
    Pet aPet; // just a sample using a class that is not a subclass of OptimizedPersistable
    ByteEnum m_enumByte;
    public ByteEnum EnumByte
    {
      get
      {
        return m_enumByte;
      }
      set
      {
        Update();
        m_enumByte = value;
      }
    }
    public object[] m_objectArray;
    Int16Enum m_enumInt16;
    Int32Enum m_enumInt32;
    ISomeStuff[] m_objectInterfaceArray;
    public Int32Enum EnumInt32
    {
      get
      {
        return m_enumInt32;
      }
      set
      {
        Update();
        m_enumInt32 = value;
      }
    }
    Int64Enum m_enumInt64;
    public Int64Enum EnumInt64
    {
      get
      {
        return m_enumInt64;
      }
      set
      {
        Update();
        m_enumInt64 = value;
      }
    }

    UInt64Enum m_enumUInt64;
    public UInt64Enum EnumUInt64
    {
      get
      {
        return m_enumUInt64;
      }
      set
      {
        Update();
        m_enumUInt64 = value;
      }
    }

    List<UInt64Enum> m_ListenumUInt64;
    public List<UInt64Enum> ListEnumUInt64
    {
      get
      {
        return m_ListenumUInt64;
      }
      set
      {
        Update();
        m_ListenumUInt64 = value;
      }
    }
    List<UInt64Enum?> m_ListenumUInt64Nullable;
    public List<UInt64Enum?> ListEnumUInt64Nullable
    {
      get
      {
        return m_ListenumUInt64Nullable;
      }
      set
      {
        Update();
        m_ListenumUInt64Nullable = value;
      }
    }

    PersistenceByInterfaceSnake aSnake;
    byte m_aByte;
    public byte AByte
    {
      get
      {
        return m_aByte;
      }
      set
      {
        Update();
        m_aByte = value;
      }
    }
    SByte m_sByte;
    public SByte SByte
    {
      get
      {
        return m_sByte;
      }
      set
      {
        Update();
        m_sByte = value;
      }
    }
    public string aString;
    char m_aChar;
    public char AChar
    {
      get
      {
        return m_aChar;
      }
      set
      {
        Update();
        m_aChar = value;
      }
    }
    public float single;
    public double aDouble;
    public UInt16 uint16;
    public UInt32 uint32;
    public UInt64 uint64;
    public Int16 int16;
    public Int32 int32;
    public Int64 int64;
    public DateTime dateTime;
    public TimeSpan timeSpan;
    public Decimal aDecimal;
    byte? m_nullableByte;
    public byte? NullableByte
    {
      get
      {
        return m_nullableByte;
      }
      set
      {
        Update();
        m_nullableByte = value;
      }
    }
    SByte? m_nullablesByte;
    public SByte? NullablesByte
    {
      get
      {
        return m_nullablesByte;
      }
      set
      {
        Update();
        m_nullablesByte = value;
      }
    }
    char? m_nullableChar;
    public char? NullableChar
    {
      get
      {
        return m_nullableChar;
      }
      set
      {
        Update();
        m_nullableChar = value;
      }
    }
    public float? nullablesingle;
    public double? nullableaDouble;
    public UInt16? nullableuint16;
    public UInt32? nullableuint32;
    public UInt64? nullableuint64;
    public Int16? nullableint16;
    public Int32? nullableint32;
    public Int64? nullableint64;
    DateTime? m_nullabledateTime;
    public DateTime? NullableDateTime
    {
      get
      {
        return m_nullabledateTime;
      }
      set
      {
        Update();
        m_nullabledateTime = value;
      }
    }

    public TimeSpan? nullabletimeSpan;
    public Decimal? nullableDecimal;
    WeakIOptimizedPersistableReference<OptimizedPersistable> m_weakIOptimizedPersistableReference;
    public WeakIOptimizedPersistableReference<OptimizedPersistable> WeakIOptimizedPersistableReference
    {
      get
      {
        return m_weakIOptimizedPersistableReference;
      }
      set
      {
        Update();
        m_weakIOptimizedPersistableReference = value;
      }
    }
    byte?[] nullablebyteArray;
    char?[] nullablecharArray;
    UInt16?[] nullableuint16Array;
    UInt32?[] nullableuint32Array;
    UInt64?[] nullableuint64Array;
    Int16?[] nullableint16Array;
    Int32?[] nullableint32Array;
    Int64?[] nullableint64Array;
    float?[] nullablefloatArray;
    double?[] nullabledoubleArray;
    DateTime?[] nullableDateTimeArray;
    Decimal?[] nullableDecimalArray;
    Oid?[] nullableOidArray;
    byte[] byteArray;
    char[] charArray;
    UInt16[] uint16Array;
    UInt32[] uint32Array;
    UInt64[] uint64Array;
    Int16[] int16Array;
    Int32[] int32Array;
    Guid?[] nullableGuidArray;
    Int64[] int64Array;
    float[] floatArray;
    double[] doubleArray;
    DateTime[] dateTimeArray;
    Oid[] oidArray;
    List<byte> listByte; // all List<> use wrapper OptimizedPersistable looked up from a parent collection
    List<Person> personList;
    List<WeakIOptimizedPersistableReference<OptimizedPersistable>> m_weakIOptimizedPersistableReferenceList;
    List<WeakIOptimizedPersistableReference<OptimizedPersistable>> WeakIOptimizedPersistableReferenceList
    {
      get
      {
        Session?.LoadFields(this);
        return m_weakIOptimizedPersistableReferenceList;
      }
      set
      {
        m_weakIOptimizedPersistableReferenceList = value;
      }
    }
    List<Int16> m_int16List;
    public List<Int16> Int16List
    {
      get
      {
        Session.LoadFields(this);
        return m_int16List;
      }
      set
      {
        Update();
        m_int16List = value;
      }
    }
    List<UInt16> m_uint16List;
    public List<UInt16> Uint16List
    {
      get
      {
        Session?.LoadFields(this);
        return m_uint16List;
      }
      set
      {
        Update();
        m_uint16List = value;
      }
    }
    List<Int32> int32List;
    List<UInt32> uint32List;
    List<Int64> m_int64List;
    public List<Int64> Int64List
    {
      get
      {
        Session?.LoadFields(this);
        return m_int64List;
      }
      set
      {
        Update();
        m_int64List = value;
      }
    }
    List<UInt64> uint64List;
    List<String> m_stringList;
    public List<String> StringList
    {
      get
      {
        Session?.LoadFields(this);
        return m_stringList;
      }
      set
      {
        Update();
        m_stringList = value;
      }
    }
    List<Oid> oidList;
    List<Oid?> nullableoidList;
    [UseOidShort]
    Person[] personArrayOidShort;
    [UseOidShort]
    List<Person> personListShort;
    [UseOidShort]
    List<Pet> m_petListOidShort;
    List<Pet> petListLongOid;
    VelocityDbList<byte> m_odblistByte; // VelocityDbList is like List but is a subclass of OptimizedPersistable which makes it perform better by avoiding collection lookup
    public VelocityDbList<byte> OdblistByte
    {
      get
      {
        Session?.LoadFields(this);
        return m_odblistByte;
      }
      set
      {
        Update();
        m_odblistByte = value;
      }
    }
    VelocityDbList<Person> m_personGenericList;
    public VelocityDbList<Person> PersonGenericList
    {
      get
      {
        Session?.LoadFields(this);
        return m_personGenericList;
      }
      set
      {
        Update();
        m_personGenericList = value;
      }
    }
    VelocityDbList<WeakIOptimizedPersistableReference<OptimizedPersistable>> m_weakIOptimizedPersistableReferenceOdbList;
    public VelocityDbList<WeakIOptimizedPersistableReference<OptimizedPersistable>> WeakIOptimizedPersistableReferenceOdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_weakIOptimizedPersistableReferenceOdbList;
      }
      set
      {
        m_weakIOptimizedPersistableReferenceOdbList = value;
      }
    }
    VelocityDbList<Int16> m_int16OdbList;
    public VelocityDbList<Int16> Int16OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_int16OdbList;
      }
      set
      {
        Update();
        m_int16OdbList = value;
      }
    }
    VelocityDbList<UInt16> m_uint16OdbList;
    public VelocityDbList<UInt16> Uint16OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_uint16OdbList;
      }
      set
      {
        Update();
        m_uint16OdbList = value;
      }
    }

    VelocityDbList<Int32> m_int32OdbList;
    public VelocityDbList<Int32> Int32OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_int32OdbList;
      }
      set
      {
        Update();
        m_int32OdbList = value;
      }
    }
    VelocityDbList<UInt32> m_uint32OdbList;
    public VelocityDbList<UInt32> Uint32OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_uint32OdbList;
      }
      set
      {
        Update();
        m_uint32OdbList = value;
      }
    }
    VelocityDbList<Int64> m_int64OdbList;
    public VelocityDbList<Int64> Int64OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_int64OdbList;
      }
      set
      {
        Update();
        m_int64OdbList = value;
      }
    }
    VelocityDbList<UInt64> m_uint64OdbList;
    public VelocityDbList<UInt64> Uint64OdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_uint64OdbList;
      }
      set
      {
        Update();
        m_uint64OdbList = value;
      }
    }
    VelocityDbList<String> m_stringOdbList;
    public VelocityDbList<String> StringOdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_stringOdbList;
      }
      set
      {
        Update();
        m_stringOdbList = value;
      }
    }
    VelocityDbList<Pet> m_petOdbList;
    public VelocityDbList<Pet> PetOdbList
    {
      get
      {
        Session?.LoadFields(this);
        return m_petOdbList;
      }
      set
      {
        Update();
        m_petOdbList = value;
      }
    }
   ArrayList petList2;
    public Slot aSlot;
    public Slot[] m_slots;
    BTreeSet<Person> m_bTreePerson;
    public BTreeSet<Person> BTreePerson
    {
      get
      {
        Session?.LoadFields(this);
        return m_bTreePerson;
      }
      set
      {
        Update();
        m_bTreePerson = value;
      }
    }
    SortedSetAny<Person> m_sortedSetPerson;
    public SortedSetAny<Person> SortedSetPerson
    {
      get
      {
        Session?.LoadFields(this);
        return m_sortedSetPerson;
      }
      set
      {
        Update();
        m_sortedSetPerson = value;
      }
    }
    SortedMap<byte, Person> m_sortedMapByteToPerson;

    SortedMap<byte, Person> SortedMapByteToPerson
    {
      get
      {
        return m_sortedMapByteToPerson;
      }
      set
      {
        Update();
        m_sortedMapByteToPerson = value;
      }
    }
    VelocityDbHashSet<Person> personHashSet;
    Guid? m_nullableGuid;

    public Guid? NullableGuid
    {
      get
      {
        return m_nullableGuid;
      }
      set
      {
        m_nullableGuid = value;
      }
    }
    public struct Slot
    {
      public int hashCode;
      public Person value;
      public int next;
    }

    public AllSupported(Int32 arraySize)
    {
      _uint64EnumArray = new UInt64Enum[arraySize];
      if (arraySize > 1)
        _uint64EnumArray[1] = UInt64Enum.dd;
      enum16list = new List<Int16Enum>(arraySize);
      aSnake = new PersistenceByInterfaceSnake("Curly", 1, true, 58);
      jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
      jaggedArray[1] = new int[] { 0, 2, 4, 6 };
      jaggedArray[2] = new int[] { 11, 22 };
      m_nullabledateTime = null;
      m_nullableByte = null;
      m_enumByte = ByteEnum.b;
      m_enumInt16 = Int16Enum.c;
      m_enumInt32 = Int32Enum.f;
      m_enumInt64 = Int64Enum.ff;
      m_enumUInt64 = UInt64Enum.ff;
      ListEnumUInt64 = new List<UInt64Enum>();
      ListEnumUInt64.Add(m_enumUInt64);
      ListEnumUInt64Nullable = new List<UInt64Enum?>();
      ListEnumUInt64Nullable.Add(null);
      ListEnumUInt64Nullable.Add(m_enumUInt64);
      m_objectArray = new object[arraySize];
      m_objectInterfaceArray = new ISomeStuff[arraySize];
      byteArray = new byte[arraySize];
      charArray = new char[arraySize];
      m_weakRefArray = new WeakIOptimizedPersistableReference<IOptimizedPersistable>[arraySize];
      uint16Array = new UInt16[arraySize];
      uint32Array = new UInt32[arraySize];
      uint64Array = new UInt64[arraySize];
      int16Array = new Int16[arraySize];
      int32Array = new Int32[arraySize];
      int64Array = new Int64[arraySize];
      floatArray = new float[arraySize];
      doubleArray = new double[arraySize];
      dateTimeArray = new DateTime[arraySize];
      oidArray = new Oid[arraySize];
      nullablebyteArray = new byte?[arraySize];
      nullablecharArray = new char?[arraySize];
      nullableuint16Array = new UInt16?[arraySize];
      nullableuint32Array = new UInt32?[arraySize];
      nullableuint64Array = new UInt64?[arraySize];
      nullableint16Array = new Int16?[arraySize];
      nullableint32Array = new Int32?[arraySize];
      nullableint64Array = new Int64?[arraySize];
      nullablefloatArray = new float?[arraySize];
      nullabledoubleArray = new double?[arraySize];
      nullableDateTimeArray = new DateTime?[arraySize];
      nullableDecimalArray = new Decimal?[arraySize];
      nullableGuidArray = new Guid?[arraySize];
      nullableOidArray = new Oid?[arraySize];
      listByte = new List<byte>(arraySize); // just samples of what Key can be
      personList = new List<Person>(arraySize);
      m_petListOidShort = new List<Pet>(arraySize);
      petListLongOid = new List<Pet>(arraySize);
      petList2 = new ArrayList(arraySize);
      int32List = new List<Int32>(arraySize);
      uint32List = new List<UInt32>(arraySize);
      uint64List = new List<ulong>(arraySize);
      oidList = new List<Oid>(arraySize);
      nullableoidList = new List<Oid?>(arraySize);
      personHashSet = new VelocityDbHashSet<Person>();
      person = new Person();
      timeSpan = new TimeSpan(1, 0, 0);
      personArrayOidShort = new Person[arraySize];
      if (arraySize > 1)
        personArrayOidShort[1] = new Person();
      personArrayOidShort[0] = null;
      personListShort = new List<Person>(arraySize);
      personListShort.Add(null);
      personListShort.Add(null);
      personListShort.Add(new Person());
      aPet = new Cat("Boze", 5);
      m_petListOidShort.Add(aPet);
      m_petListOidShort.Add(null);
      aPet = new Cat("Fendy", 4); // create a new cat so that first cat is created within same database as owner (OidShort)
      petListLongOid.Add(aPet);
      petList2.Add(aPet);
      uint32List.Add(5555);
      int32List.Add(-66666);
      uint64List.Add(8989898988989);
      doubleArray[0] = 0.2323232323232;
      aSlot = new Slot();
      aSlot.value = new Person();
      m_slots = new Slot[5];
      enum16list.Add(m_enumInt16);
      nullableoidList.Add(new Oid((ulong)4444));
      nullableoidList.Add(null);
      nullableoidList.Add(new Oid((ulong)8888));
      if (arraySize > 0)
      {
        oidArray[0] = new Oid((ulong)99999);
        nullableOidArray[0] = new Oid((ulong)99999);
        nullableint32Array[0] = 5;
      }
      if (arraySize > 2)
      {
        m_objectArray[1] = this;
        m_objectInterfaceArray[2] = this;
        oidArray[2] = new Oid((ulong)66666);
        nullableOidArray[2] = new Oid((ulong)66666);
        nullableint32Array[2] = 6;
      }
      for (int i = 0; i < 5; i++)
      {
        m_slots[i].hashCode = i;
        m_slots[i].value = new Person();
        m_slots[i].next = i + 1;
      }
    }
  }
}
