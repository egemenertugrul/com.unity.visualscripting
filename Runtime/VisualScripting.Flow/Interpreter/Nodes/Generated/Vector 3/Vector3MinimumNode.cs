// GENERATED FILE, do not edit by hand
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Interpreter;
using UnityEngine;

namespace Unity.VisualScripting.Interpreter
{
    [NodeDescription(typeof(Unity.VisualScripting.Vector3Minimum))]
    public struct Vector3MinimumNode : IDataNode, IFoldableNode
    {
        public InputDataMultiPort Inputs;
        public OutputDataPort Minimum;

        public void Execute<TCtx>(TCtx ctx) where TCtx : IGraphInstance
        {
            var result = ctx.ReadVector3(Inputs.SelectPort(0));
            for (uint i = 1; i < Inputs.DataCount; i++)
                result = Vector3.Min(result, ctx.ReadVector3(Inputs.SelectPort(i)));
            ctx.Write(Minimum, result);
        }
    }
}
