using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Hero_HeroCommonAutoAI_node945 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(3990708623u);
			((ObjAgent)pAgent).RealMoveToActor(objID);
			return EBTStatus.BT_SUCCESS;
		}
	}
}
