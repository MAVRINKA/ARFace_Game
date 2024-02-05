using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider timeSlider;

    public TextMeshProUGUI txt;
    private string txtAudio;

    [SerializeField] float[] timeAudio;

    public enum NumbAudio { BeliyAist, Grach, Zyablik, Lastochka, Perepel, SerayaCaplya, Skvorec, Utka, ChrniyAist, Chibisi }
    public NumbAudio numbAudio;

    private void Awake()
    {
        //txtAudio = txt.text;
    }

    private void OnEnable()
    {
        PlayBtn();
    }
    private void Update()
    {

        if (audioSource.isPlaying)
        {
            timeSlider.maxValue = audioSource.clip.length;
        }

        Debug.Log(audioSource.time);

        switch (numbAudio)
        {

            #region BeliyAist
            case NumbAudio.BeliyAist:


                if (audioSource.time >= timeAudio[0])
                 {
                    txt.text = "���� ����� � ������� ���������� ���� � ���������, ��������� ������ ����������� �����. ��� �������������� ����� ������ �������������� �� ����� �������� �������. ����, �� ������� ����� ����� � ����������, ��� �����. �� ��� ������� � �����, ����������� � ������������. ";
                 }


                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "���� ��������� ����� �� ���������� ����������� - �����-�� ����� ���� ������� ���������. ������ ��� �������� ������, �� �� ��� ��� � � ������ ������ ��������� �����������: ����� � ���.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "� ���������� ������ ��������� ������� ��������� ����� ��������� � �����. ����������� � ��� ����� ��������� � ������ ������ �������, ��� ������. � ��������� ����� ���� ��������, ����������� ��������� �� �������. ����� ����� ����� �������� � ����������� ���� � ������ ������ ����.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "������� � ���� �� ���������� ����������� �����, ������������ �����������, ������ ����� ������� ��� �����. ������� ������ ������� ������������ ������ �� ������ � ����, ��� � 304 ���� ����� ���. ������������ ������ ����� ����� ������ ���������� �� ����� � � ��� ����� �������� ��������� ���������� � ���������.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "����������� ���� ����� � �������, ���� �� ����� ���������������� ����������� ������. ����� ������� ������ ���� ���, ����� �� �������� �� ������ ���������� � ���������� � �����������. �������������, ��� ������ ���� ���� ��������� ������� ���� ������������ ��� �������� ��� � ����� � ���� �����������.";
                }

                if (audioSource.time >= timeAudio[5])
                {
                    txt.text = "������ �������� �������� �� ���� ��� ������������ ������� ������, ��� ������������ ����������� ����� � ����������� ����������� � ��������� ���������. ��������� ���������� ��� ����������� ��������, �������� � ����� (������� ����������, ��������� �� ���� ������� �������). ";
                }

                if (audioSource.time >= timeAudio[6])
                {
                    txt.text = "���������� ��������� ���� ���������� ��������� ������������� �������� � 1752 ����. �� ���������� 223 ��� ���������� ������������ ��� ���������� ��� �������� ������� ������� ����, ������ � �������. ����������� ������ ������������� � 1975, �� ������������� ������� ��������������� ������, � ��� ����� � ������ �����.";
                }

                if (audioSource.time >= timeAudio[7])
                {
                    txt.text = "����-����������� ���������� ������ ���������� �� �����-������� ����, � �� ��� ��� ����� �� ������������ ������� ���������. ��������� ����� �� ����� �������� ������� ������� ����� ������ �� ���� ����. �� ������ � ��� ���� ����� ������������ �� ������ � 1990 ����, ��� �� ������� ����� �������� � ������������� � ���������� ��������.";
                }

                break;
            #endregion

            #region Grach
            case NumbAudio.Grach:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�������� ����� � ���������� ������ ������� ���� ������ �������� ����� ���� � �� ������. �� ��� ��� ����� �� ����� �������� ����������� � ����������� ������ � ���������. ������ ������������ ����� �������� ��������� � 6 ������� ����������� ���, ������!�";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "������ ����� ��������� ��� ������� ������ �� ������, ��� ��� ��� �������. ���� ����, ������ � ������ XIX ����, ������ �������������� ����������� �������� ������������ ����. �������� � ������ ���� �������, ������� ���������� ����� �� ���� ������������ ����� � ����� ������� ���� ����� ��� �������, �������� �� ������� �� ��������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "���� ������ ������� ����� �� ��������, ����� ��� ����� �� ���������� ������ �����, ��� ��. ������ � ���� ������ 20 ���, �� � ������� ����� ��� ��� ������� ����������� ���� ������ �������, �����, ������������ � ���� ��������� ��������� � ������� �������.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "���� � ����������� ������� ������. ������� �������� ���� �������, ������, �������, ����� ������� � ������ ������ � � ��� ��������� ��������� ��������, ����� ��� ������������ ������. �������� �������� �������, ��������� ������� ��������� �������� ��� ��� ������ � ���� �� ������ � � ������ ��� �� ��� ���.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "��� ������ ������� ����� ������������ �������. �� ������� ����������� ������ � ��������� ��������� �������������. ����� ��������� ������ ������� ��� �������� ������� ������������ ��� ������������� ���� �������, ����������� ������ ���� ���������. � ������ ����� ����� � ���������� ������� � ��� �� ������ ����.";
                }
                break;
            #endregion

            #region Zyablik
            case NumbAudio.Zyablik:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�������� ���� ���������� ��� �������� � 2006 ���� � ������ �� ������ �����, ����������� ��� �� ������� ����. � ������ ����� � ������� �������, ���������� ���� ���� � �������� ���������� ������, �������������, ��� ���������� ������ � ������� �����.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "����� ��������� � ����� �������� ������ � ��������� ����������� ���� � �������� �������. ���������, ��� �� ����� �� ������ � ������ �� ���������� ������� �����������. ����� ��� ������ ��� ����� � ���������� ������� � ��������� ������� �����. ��� ����� �������� ��������� ����, ����� ��������� � �������� � ����� ���������� ������� ���������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "����� � ���������� ������������ �������� ����������� ����������, ���������������� �� ���� ����������� ����. ������� �� ������������� ��������� ������ �� ��� ���, ������ ������ �� ����, � ��� �����������.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "����� � ������������ ����� ����������� � ������� ��������. �� ����� ���� ������, ���������, �����������, �������� � ��� �����. ���� ����� ��������� � �����, � ��� ����� ������� ������� �� ��� �������. ����� ������ ����������� ��� ���� (������������ �������, ������� ������ � ����� ������������ ����).";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "������� ������� ��������� ���� �� ���� ��� ��������� ������, ������� ������� �� ������������� ��������� ���������. ���� ���������� ������� � ���� ����� �� ����� ����, ��������� ��������� ���������� �������� ����� ��������� ��������. �� ���� �� ����. ��� �������� ���� �����������, �� ��������� ��� ��������� �����.";
                }

                if (audioSource.time >= timeAudio[5])
                {
                    txt.text = "����������� � ���� �� ���������� ������, ������������ �� ����������� ����� � ������. ��� ���� �� ����� ������� ������� � ����, ��� ������� �� ������������ ���� � �������� ����� 75 000 ���������. ������������� ��������� ������ ���� ������ � �������� � �������� � �� �������. � ������ ���� ��������� ����������� ���������, �������� ������ ����� � ���������� ������.";
                }
                break;
            #endregion

            #region Lastochka
            case NumbAudio.Lastochka:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�����, ��� ����� ������, ����� ������� ����������� ���� ������� ����� �������� ��������. � ���������� ������ ������������� ��� ��� �������� ��������� �������� ����������� ������������, ������������ ����� �� ��������, ������������ ��������. � ��� ����� ��� �������� � ������� ������ � ������� ������, ����� ������������ �����, ��������� �����.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "� ����� ����������� ���������� ����������� ���������: ����������, ���������� ��������������� �� ������� ����� ������ ������ � �������� �� ���������� �����. ���������, ��� ������������� � ��� ����� ���������� ����� ������� �����. ����������� ��������� �������� ������������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "���� ��������� ����� �� ���������� ����������� - �����-�� ����� ���� ������� ���������. ������ ��� �������� ������, �� �� ��� ��� � � ������ ������ ��������� �����������: ����� � ���.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "� ���������� ������ ��������� ������� ��������� ����� ��������� � �����. ����������� � ��� ����� ��������� � ������ ������ �������, ��� ������. � ��������� ����� ���� ��������, ����������� ��������� �� �������. ����� ����� ����� �������� � ����������� ���� � ������ ������ ����.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "���������� ����������� �������� ���� �� ���������� � ����, � ��������� �� ��� ��� ���������� ������������ �����������. ����� ��������� �� ��� � �������, ������������� ��������� ����������. � ��� ���������, ��� ������ �������� �������� ���� � �����.";
                }

                if (audioSource.time >= timeAudio[5])
                {
                    txt.text = "��������� � ���� �� �������� ���������� ������ ������, � ���� �� ����� �������. ���� ���� ������� ����������� ��������, �� ������������� �������� ��������� ��������� ��� ����� ������ � ����������. ������ �� ��������� ������� ����� 600000 �������.";
                }

                if (audioSource.time >= timeAudio[6])
                {
                    txt.text = "������� ������������ ������������ ������� � ����� �������� ������� ������, ��������� �� ������������� �����������. ������� ������ ������ ����������� ������������ ��������������� ���������� ����� ���� ������ �������, ���� �� ���� �����������-���������������� ��������. � 1961 ���� � �������� 35 ��� �� ��� ���� ������������ �������. ��� ������������� ����� ��������� ���������� ��������� ������� ������� ���� ����� � �� ���������.";
                }
                break;
            #endregion

            #region Perepel
            case NumbAudio.Perepel:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "���������� �������, ��������� �� �������� ���������� ������ ������, ����� �� ����� ��� � ������� �� ������������� ������. � ����������� ����� ����� ��������������� ������� ����, � ��������� ������ �������� ������ �������� �����. ��������� ������ ����������� ���� � � ������, � �� �������.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "����� �������� � ��������� ��������, ����, �� ������ ������������ ������������ ������������ ������ ������. ��������� �� ������ ������������ �����������, �� � ���������� �� ��������� ������ ����� � ��������. ���������� ���� � � ��� ����� ������ ������ �� ��������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "������� �����, ��� �������, ����� ���� ������ ����� ������������� ������� '��� � ���' ����� �� ����� ����, ���� ���������� �����, ���������� �������. ��� �����, ��� �������, ������ ��� �����. ����� ������� �� ���������� ������, ��� ���������. ��� ������ ��������� �� �����.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "��������� ����� ������ � ������ � ������� � ���, ��������, ���������� ����� � ������� ����������� ����������. ��� �������� ������������ �������� ��������� � ���������� �� ��������� ����� ����� ������� � �������� � � ���������, � � ����������� ������ �� ������ ���� ����� �� ����. ������ ������ �� ��� ��� ��������� ����������� � ���������� � ���������������� � ������ ������, � ��� ����� � �������.";
                }
                break;
            #endregion

            #region SerayaCaplya
            case NumbAudio.SerayaCaplya:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�������� ����� ������ ��������� ������ �� ����� ������� � ������ � ����� ���� ������������� ������� � ���� ��������� ���� ��������� �������������. ����� ����� ��������, ������ ����� ���� ��� ��� ������, ��� ���� � � �������������� ����������� �����. ������ ����� �������� ������� �������������� �������.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "�����������, ��� ����� ��������� ������� ���������� ����� �� ������: ������ �������, ����� �����, ���� �����, ���� ���������. �� �� �� ����� ��������� ������� ������ ��������, ���������� ���� ��������. ������, ��� ������� ����� �� ����� ���� ����� ������, � � ������ �� �������� ������������ ������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "��� ����� ��������� ��������� ���� ����� ���������� ������. ��������, ������� ��������� ��������� �� ����� �����, ��� ������������� ��������� �� ������������� ���������, ��� ��� �� ������ ���������� ��� ���� ��������. ������� ����� - ��� � �����-�� ������� ����������� � ����� ����, ��������� �� ������� �������� ����������� �� ������ ���������";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "�� ��� �����, �� ����� ����� ����� ��� ������� �������� � �������� �� ��, ��� ������ �� ������� ���� ������������� ������� ������. ��-�� ����� �� ���� ���������� �� ����� ��������� ����� ������: ������� ����������� ��� ����� ���������� ����� � �� ��� ����������� � ����� ����� � ���������. ��� �������� ��������, �� �� ������� ������� ����� �� ������� ������ � ������ � �� ����� ����� ����� � ���.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "�������� � ���� �� �������� �����, ��� ����������� �������� �������, � ��� ����� � �� ����. ������ ���������� ����� ��������� ����� � ������ �� �������������, ������� ������ ���� ������ ������ �� ���� ���. �������� ����� � �� ����������: ��� ������� �������, ��������� ��, ��� � �� ����, ����� ������ ������������� �������� ���. ";
                }
                break;
            #endregion

            #region Skvorec
            case NumbAudio.Skvorec:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "���������� �������, ��������� �� �������� ���������� ������ ������, ����� �� ����� ��� � ������� �� ������������� ������. � ����������� ����� ����� ��������������� ������� ����, � ��������� ������ �������� ������ �������� �����. ��������� ������ ����������� ���� � � ������, � �� �������.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "������ ��������� ����������� �������� ���������� ���-�� ����� �����������; ��������, ����� ������ O-Zone ����� ������� �����, ��������� ������ ������ ������ �� � ���������. ����� ����� ������������ �� ������� ���������� ����� �������� ��������, ������� ����� �� ����� ����������� �� ����� ������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "����� �������� � ��������� ��������, ����, �� ������ ������������ ������������ ������������ ������ ������. ��������� �� ������ ������������ �����������, �� � ���������� �� ��������� ������ ����� � ��������. ���������� ���� � � ��� ����� ������ ������ �� ��������.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "����� � ��� ��������� ���������� �������� ��� ����������� ����� � ����� ��� ����� ��������. ��� ���� ������ ����� ������ �� ��������� � �����, � ������ ����������� ������� � ������� ���� ���������� ����� ����������. ��� ��� �������� ������ ���� ��������� �������-��������� ����� � ������������ �����.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "��� ������ ������� ����� ������������ �������. �� ������� ����������� ������ � ��������� ��������� �������������. ����� ��������� ������ ������� ��� �������� ������� ������������ ��� ������������� ���� �������, ����������� ������ ���� ���������. � ������ ����� ����� � ���������� ������� � ��� �� ������ ����.";
                }

                if (audioSource.time >= timeAudio[5])
                {
                    txt.text = "�� ���������� ���� �������� ������ ���� �������� ����� �����������-��������. � ������ ����� ����������� �������. ����������� �� ������ � ��������� ������������� ����������� ��������, ��������� � ��������� � ������� �, �������, ���������� �����������: ����� ������ �����, ������� ������� ������ ��� ��������� ��� ������.";
                }
                break;
            #endregion

            #region Utka
            case NumbAudio.Utka:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�������� ����� ������ ��������� ������ �� ����� ������� � ������ � ����� ���� ������������� ������� � ���� ��������� ���� ��������� �������������. ����� ����� ��������, ������ ����� ���� ��� ��� ������, ��� ���� � � �������������� ����������� �����. ������ ����� �������� ������� �������������� �������.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "��������� �������� ������ ����� � ���������� �������� ���������� ����������. �������� ������� ��������� �� ���� ����������� ������ � �����. ����� ����� ������, � ������ ������� � ������� ����� �� ������ �����.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "������ ����� ��������� ��� ������� ������ �� ������, ��� ��� ��� �������. ���� ����, ������ � ������ XIX ����, ������ �������������� ����������� �������� ������������ ����. �������� � ������ ���� �������, ������� ���������� ����� �� ���� ������������ ����� � ����� ������� ���� ����� ��� �������, �������� �� ������� �� ��������.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "����������� ���������� ������ ��� �������-��������� ������������ �� ������� �������� ����� ø�� � 1815 ����. ����� ������������ ��� ����������� �� ������� ������� �elverkonge�, ��� ������������ ���� ��� �� ������� �����, � ��������� �������. ������� �������� ������ � ���� ������������� ��������� ���������� �������� ������� ���������� ����������.";
                }

                if (audioSource.time >= timeAudio[4])
                {
                    txt.text = "������� ����� ������� ���� ������ ��������� ���������� ��������� ��������� ������� �� ����� ������ ������������� � ������. �������, ����� ��������� �� ��� � ��� ���������� ������ 1998 ���� � �� �, �������, ����������� �������. ���� ������ ����� � ����� ������ � ������������������ ���������: �� ��� ��� ��������� ������������ � �������� ����� �� ������ �������� ������� � ����� ��� ������ � ����� ���� �������, ������ �����.";
                }

                if (audioSource.time >= timeAudio[5])
                {
                    txt.text = "�������� � ���� �� ������ ����� � ��������� ��������, ����������� ��� ������������ � ��������� ��������. ������������ �������� ����������� ��� �������� ������������� ��� ������������� ���������. ������� ������� �������� � ������� ������ � ������� � �������� � ��������� ���� � �������� �������, � ������� � � ����� ������ � ����� �������� � ������� �������..";
                }
                break;
            #endregion

            #region ChrniyAist
            case NumbAudio.ChrniyAist:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "�������� ���� ���������� ��� �������� � 2006 ���� � ������ �� ������ �����, ����������� ��� �� ������� ����. � ������ ����� � ������� �������, ���������� ���� ���� � �������� ���������� ������, �������������, ��� ���������� ������ � ������� �����.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "� ����� ������ ���������� ���� -- ��� ��, ��� � ��������� � �����. � ���������� ����� ��� ����� ��������� ������ ���� ���������� ��������, ��� ������� � ��������� ������ ������� ��������. � ��� � ����� ���� ���� ������� ���������� ������������: ��� ������ ��������, ����������, ����������, �������������, ��������, ��������, ��������� � �������.";
                }
                break;
            #endregion

            #region Chibisi
            case NumbAudio.Chibisi:
                if (audioSource.time >= timeAudio[0])
                {
                    txt.text = "������, ��� �������� ����� � ������� ��������, ���������� ������ ������� ��������� ����������� �������� ��������. �������� ��������� ����� ����������� � ���, ��� ����� ��� ������������ ��� �����: �������� � ������� � ����. ������ �������� ����� ����� ���������� � �������������� ���� ��� �������� ���������� ��������� ��������������.";
                }

                if (audioSource.time >= timeAudio[1])
                {
                    txt.text = "� ����� ������ ���������� ���� -- ��� ��, ��� � ��������� � �����. � ���������� ����� ��� ����� ��������� ������ ���� ���������� ��������, ��� ������� � ��������� ������ ������� ��������. � ��� � ����� ���� ���� ������� ���������� ������������: ��� ������ ��������, ����������, ����������, �������������, ��������, ��������, ��������� � �������.";
                }

                if (audioSource.time >= timeAudio[2])
                {
                    txt.text = "������� k-pop, ����������� ���� ���, ��������� ����� ����� � ���� ���. �������� ��������� �������������� ����� � ���������, ����������� �����������, �������� ������� � ���� ������� �����, � ������ ��� ��� �� ������� ������, ������� ����� �����������. ������. ����� ��������� � ��� ��������� ������ BTS �� ��� ����� ������������� ���� �������, ����� � ������� ����� ������ ������������ ��� ��������� ������ ������� ������.";
                }

                if (audioSource.time >= timeAudio[3])
                {
                    txt.text = "�� ������ ���� �������� ������������ ���������� ���� ������� ���������� �����. ������ �� ���, ������, �����.  ����������� ����� �� ������������ �� ������, ���� �� ����������� ������, � ������ ������� � ������� ��������� ������-��������, ������������� �� �������, ����� ��� ���������� �����. ����������� ���� � ���������� ���������� � ������� ������������ � ��������.";
                }
                break;
                #endregion
        }

    }

    public void OnSliderValueChanged()
    {
        audioSource.time = timeSlider.value;
    }

    private void FixedUpdate()
    {
        if (audioSource.isPlaying)
        {
            timeSlider.value = audioSource.time;
        }
    }

    public void PlayBtn()
    {
        audioSource.Play();
    }

    public void PauseBtn()
    {
        audioSource.Pause();
    }

    public void StopBtn()
    {
        audioSource.Stop();
        ResetAudioPlayer();
    }

    public void ResetAudioPlayer()
    {
        audioSource.time = 0;
        timeSlider.value = 0;
        txt.text = txtAudio;
        audioSource.Stop();
    }

}