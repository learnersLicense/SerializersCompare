﻿namespace SerializersCompare.Serializers
{
    public interface ITestSerializers<T>
    {
        string GetName();
        bool IsBinary();

        dynamic Serialize(object thisObj); // Most serializers don't need the <T> generic
                                              // but few DO (eg .NET XML).
        T Deserialize(dynamic serInput);
    }
}
