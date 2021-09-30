// GENERATED FILE, do not edit by hand
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Interpreter;
using UnityEngine;

namespace Unity.VisualScripting.Interpreter
{
    [NodeDescription(typeof(Unity.VisualScripting.Vector4DotProduct))]
    public struct Vector4DotProductNode : IDataNode, IFoldableNode
    {
        public InputDataPort A;
        public InputDataPort B;
        public OutputDataPort DotProduct;

        public void Execute<TCtx>(TCtx ctx) where TCtx : IGraphInstance
        {
            ctx.Write(DotProduct, Vector4.Dot(ctx.ReadVector4(A), ctx.ReadVector4(B)));
        }
    }
}
