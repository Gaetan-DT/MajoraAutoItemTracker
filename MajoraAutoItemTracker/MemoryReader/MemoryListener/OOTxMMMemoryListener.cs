﻿using MajoraAutoItemTracker.Model.Enum;
using MajoraAutoItemTracker.Model.Enum.OOT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MajoraAutoItemTracker.MemoryReader.MemoryListener
{
    class OOTxMMMemoryListener : AbstractMemoryListener
    {

        private CurrentRom lastCurrentRom = CurrentRom.Unknown; // Used to prevend reading wrong rom each time when in MM

        private OcarinaOfTimeMemoryListener ocarinaOfTimeMemoryListener;
        private MajoraMaskMemoryListener majoraMaskMemoryListener;

        public OOTxMMMemoryListener(
            AbstractRomController emulatorWrapper,
            Action<List<Tuple<OcarinaOfTimeItemLogicPopertyName, object>>> callBackOOT,
            Action<List<Tuple<MajoraMaskItemLogicPopertyName, object>>> callBackMM)
            : base(emulatorWrapper)
        {
            ocarinaOfTimeMemoryListener = new OcarinaOfTimeMemoryListener(emulatorWrapper, callBackOOT);
            majoraMaskMemoryListener = new MajoraMaskMemoryListener(emulatorWrapper, callBackMM);
        }

        public override void StartThread()
        {
            base.StartThread();
        }

        public override void OnTick()
        {
            var currentRom = CheckCurrentRom();
            switch (currentRom)
            {
                case CurrentRom.OcarinaOfTIme:
                    Debug.WriteLine("Tick on OOT ROM");
                    ocarinaOfTimeMemoryListener.OnTick();
                    break;
                case CurrentRom.MajoraMask:
                    Debug.WriteLine("Tick on MM ROM");
                    majoraMaskMemoryListener.OnTick();
                    break;
                case CurrentRom.Unknown:
                    Debug.WriteLine("Unknown current ROM");
                    break;
            }
            lastCurrentRom = currentRom;
        }

        private CurrentRom CheckCurrentRom()
        {
            var arrayRoomToCheck = new List<CurrentRom>{ CurrentRom.OcarinaOfTIme, CurrentRom.MajoraMask };
            if (lastCurrentRom == CurrentRom.MajoraMask)
                arrayRoomToCheck.Reverse();
            foreach(var roomToCheck in arrayRoomToCheck)
                if (roomToCheck == CurrentRom.OcarinaOfTIme && emulatorWrapper.PerformCheckFollowingRomType(CurrentRom.OcarinaOfTIme))
                    return CurrentRom.OcarinaOfTIme;
                else if (roomToCheck == CurrentRom.MajoraMask && emulatorWrapper.PerformCheckFollowingRomType(CurrentRom.MajoraMask))
                    return CurrentRom.MajoraMask;
            // If nothing found try to find any new address
            if (emulatorWrapper.GetRomAddrStartFollowingLoaddedRom(out uint romAddrStart, out CurrentRom currentRom))
                return currentRom; 
            return CurrentRom.Unknown;
        }
    }
}
