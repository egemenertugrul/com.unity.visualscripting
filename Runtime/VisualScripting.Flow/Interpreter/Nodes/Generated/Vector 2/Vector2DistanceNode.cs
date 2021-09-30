// GENERATED FILE, do not edit by hand
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Interpreter;
using UnityEngine;

namespace Unity.VisualScripting.Interpreter
{
    [NodeDescription(typeof(Unity.VisualScripting.Vector2Distance))]
    public struct Vector2DistanceNode : IDataNode, IFoldableNode
    {
        public InputDataPort A;
        public InputDataPort B;
        public OutputDataPort Distance;

        public void Execute<TCtx>(TCtx ctx) where TCtx : IGraphInstance
        {
            ctx.Write(Distance, Vector2.Distance(ctx.ReadVector2(A), ctx.ReadVector2(B)));
        }
    }
}
