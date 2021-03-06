﻿namespace NotAllEnumItemsInspection
{
    using System;

    public class SomeClass
    {
        public void SomeMethod01(int myParam)
        {
            switch (myParam)
            {
                case (int)SomeEnum.One:
                    break;
                case (int)SomeEnum.Two:
                    break;
                case (int)SomeEnum.Four:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("myParam", myParam, null);
            }
        }

        public void SomeMethod02(SomeEnum myParam)
        {
            switch (myParam)
            {
                case SomeEnum.One:
                    break;
                case SomeEnum.Two:
                    break;
                case SomeEnum.Four:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("myParam", myParam, null);
            }
        }

        public SomeEnum SomeMethod03(string myParam)
        {
            switch (myParam.ToLower())
            {
                case "a":
                    return SomeEnum.One;
                case "b":
                    return SomeEnum.Two;
                case "c":
                    return SomeEnum.Four;
                default:
                    throw new ArgumentOutOfRangeException("myParam", myParam, null);
            }
        }
    }

    public enum SomeEnum
    {
        One,
        Two,
        Three,
        Four
    }
}
