using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_ToeFacadeDesignPattern.Types;

namespace Tic_Tac_ToeFacadeDesignPattern.Model
{
    internal class Cell
    {
        public MarkType MarkType { get; set; }

        public Cell()
        {
            MarkType = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return MarkType == MarkType.EMPTY;
        }

        public MarkType GetMark()
        {
            return MarkType;
        }

        public void SetMark(MarkType mark)
        {
            MarkType = mark;
        }
    }
    }
