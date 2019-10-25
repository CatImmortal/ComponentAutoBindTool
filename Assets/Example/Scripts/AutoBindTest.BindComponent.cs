using UnityEngine;
using UnityEngine.UI;

//自动生成于：2019/10/25 23:22:30
	public partial class AutoBindTest
	{

		private Image m_Img_Test1;
		private Button m_Btn_Test2;
		private Text m_Txt_Test3;
		private Dropdown m_Drop_Test4;
		private Image m_Img_Test4;

		private void GetBindComponents(GameObject go)
		{
			ComponentAutoBindTool autoBindTool = go.GetComponent<ComponentAutoBindTool>();

			m_Img_Test1 = autoBindTool.GetBindComponent<Image>(0);
			m_Btn_Test2 = autoBindTool.GetBindComponent<Button>(1);
			m_Txt_Test3 = autoBindTool.GetBindComponent<Text>(2);
			m_Drop_Test4 = autoBindTool.GetBindComponent<Dropdown>(3);
			m_Img_Test4 = autoBindTool.GetBindComponent<Image>(4);
		}
	}
