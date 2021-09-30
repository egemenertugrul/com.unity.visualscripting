// GENERATED FILE, do not edit by hand
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Interpreter;
using UnityEngine;

namespace Unity.VisualScripting.Interpreter
{
    [NodeDescription(typeof(Unity.VisualScripting.Vector2Normalize))]
    public struct Vector2NormalizeNode : IDataNode, IFoldableNode
    {
        public InputDataPort Input;
        public OutputDataPort Output;

        public void Execute<TCtx>(TCtx ctx) where TCtx : IGraphInstance
        {
            ctx.Write(Output, ctx.ReadVector2(Input).normalized);
        }
    }
}
