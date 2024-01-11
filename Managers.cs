using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers instance;//���ϼ� ���� ������ �̱���
    public  static Managers GetInstance() { Init(); return instance; }//�ܺο��� GetInstance ȣ�� �� Init()���� ��üũ �� ��ü�� ����� ��ȯ�ϴ� ���·� ���ư� ��
    //�ܺο��� Manager�ν��Ͻ��� ������ �� �� ����ϰ� �� �Լ�
    
    //GetInstance()�� property�������� �ٲٰ��� �ϸ�
    //public static Managers Instance { get{Init(); return s_instance;} } �� �ٲ� �� Player���� Managers mg = Mangers.Instance �������� ȣ���ϸ� ��
    
 
    void Start()
    {
        //instance = this;//�ν��Ͻ��� �ڱ� �ڽ�(ó���� ������ �Ŵ����� ������Ʈ)���� ä���-->managers��ũ��Ʈ�� ������ �����Ǿ��� �� ���� �߻�(�������� instance�� ������ manager��ũ��Ʈ�� instance ���� ������� ����
        //-->�ذ�� : 

       // GameObject go = GameObject.Find("@Managers");
       // Managers mg = go.GetComponent<Managers>();//�������� instance�� ����Ǵ� ���� @Managers �� �ϳ��� �� ��

        //-->���� @Managers ������Ʈ�� �����Ǿ��ٸ�?
        //-->instance������ null�� ����, PlayerŬ�������� GetInstance()�� ȣ������ �� null���� ���޵� �� ���� �ٷ� ��� ���� �߻�
        //instance���� null�̶��, ��Ե� @Manangers�� ã�ų� ���� ����������-->Init()����
        Init();
    }

   
    void Update()
    {
        
    }

    static void Init()
    {
        if (instance == null)//�ν��Ͻ� ���� null�϶�
        {
            GameObject go = GameObject.Find("@Managers");// --> @Managers ������Ʈ�� ã�ƺ���
            if(go==null)//@Managers ������Ʈ�� ���ٸ�
            {
                go = new GameObject { name = "@Managers" };// ������Ʈ�� ���� �����
                go.AddComponent<Managers>();//���� ���� ������Ʈ�� Managers ��ũ��Ʈ�� �ٿ��ش�
            }

            DontDestroyOnLoad(go);//���� ������Ʈ�� ������� �����Ǿ�� �ȵǱ� ������ ����.

            Managers mg = go.GetComponent<Managers>();//���� @Manager������Ʈ�� �߰��ߴٸ� Managers ��ũ��Ʈ�� �����´�
        }
    }
}
