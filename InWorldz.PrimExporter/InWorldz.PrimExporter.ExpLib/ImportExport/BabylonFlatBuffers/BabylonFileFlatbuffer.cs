// automatically generated by the FlatBuffers compiler, do not modify

namespace InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers
{

using System;
using FlatBuffers;

public struct BabylonFileFlatbuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static BabylonFileFlatbuffer GetRootAsBabylonFileFlatbuffer(ByteBuffer _bb) { return GetRootAsBabylonFileFlatbuffer(_bb, new BabylonFileFlatbuffer()); }
  public static BabylonFileFlatbuffer GetRootAsBabylonFileFlatbuffer(ByteBuffer _bb, BabylonFileFlatbuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public BabylonFileFlatbuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.Material? Materials(int j) { int o = __p.__offset(4); return o != 0 ? (InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.Material?)(new InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.Material()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MaterialsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MultiMaterial? MultiMaterials(int j) { int o = __p.__offset(6); return o != 0 ? (InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MultiMaterial?)(new InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MultiMaterial()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int MultiMaterialsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance? Instances(int j) { int o = __p.__offset(8); return o != 0 ? (InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance?)(new InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int InstancesLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<BabylonFileFlatbuffer> CreateBabylonFileFlatbuffer(FlatBufferBuilder builder,
      VectorOffset materialsOffset = default(VectorOffset),
      VectorOffset multiMaterialsOffset = default(VectorOffset),
      VectorOffset instancesOffset = default(VectorOffset)) {
    builder.StartObject(3);
    BabylonFileFlatbuffer.AddInstances(builder, instancesOffset);
    BabylonFileFlatbuffer.AddMultiMaterials(builder, multiMaterialsOffset);
    BabylonFileFlatbuffer.AddMaterials(builder, materialsOffset);
    return BabylonFileFlatbuffer.EndBabylonFileFlatbuffer(builder);
  }

  public static void StartBabylonFileFlatbuffer(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddMaterials(FlatBufferBuilder builder, VectorOffset materialsOffset) { builder.AddOffset(0, materialsOffset.Value, 0); }
  public static VectorOffset CreateMaterialsVector(FlatBufferBuilder builder, Offset<InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.Material>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartMaterialsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMultiMaterials(FlatBufferBuilder builder, VectorOffset multiMaterialsOffset) { builder.AddOffset(1, multiMaterialsOffset.Value, 0); }
  public static VectorOffset CreateMultiMaterialsVector(FlatBufferBuilder builder, Offset<InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MultiMaterial>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartMultiMaterialsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInstances(FlatBufferBuilder builder, VectorOffset instancesOffset) { builder.AddOffset(2, instancesOffset.Value, 0); }
  public static VectorOffset CreateInstancesVector(FlatBufferBuilder builder, Offset<InWorldz.PrimExporter.ExpLib.ImportExport.BabylonFlatBuffers.MeshInstance>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInstancesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<BabylonFileFlatbuffer> EndBabylonFileFlatbuffer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<BabylonFileFlatbuffer>(o);
  }
};


}
