﻿using DesignPattern.BehavioralDesignPattern.StateDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.StateDesignPattern
{
    public class ATMMachine : IATMState
    {
        public IATMState AtmMachineState = null;
        public ATMMachine()
        {
            AtmMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard()
        {
            AtmMachineState.InsertDebitCard();

            if (AtmMachineState is DebitCardNotInsertedState)
            {
                AtmMachineState = new DebitCardInsertedState();
                Console.WriteLine($"ATM Machine internal state has been changed to : {AtmMachineState.GetType().Name}");
            }
        }

        public void EjectDebitCard()
        {
            AtmMachineState.EjectDebitCard();

            if (AtmMachineState is DebitCardInsertedState)
            {
                AtmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine($"ATM Machine internal state has been Changed to : {AtmMachineState.GetType().Name}");
            }
        }
        public void EnterPin()
        {
            AtmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            AtmMachineState.WithdrawMoney();
        }
    }
}
