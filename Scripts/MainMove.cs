using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
public class MainMove : MonoBehaviour
{
    GameObject objects1, objects2, objects3, objects4, objects5, objects6, objects7, objects8; 
    public double gamma, a, b, x, y = 2, z, gamma2, a22, b2, xx, xxx, z1Start = 30, z1, z2 = 80, x_max = 30; 
    private double L, L1, a1, a2, femur = 50, tibia = 50; 
    public List<double> angles; 
    public bool vite = false, up = true, change = false, know = true, knowBegan1 = false, knowBegan2 = false;
    public bool runOnce = true; 
    void Awake() {
        objects1 = GameObject.FindGameObjectWithTag ("legDown1"); // do the tag thing
        objects2 = GameObject.FindGameObjectWithTag ("legDown2");
        objects3 = GameObject.FindGameObjectWithTag ("legDown3");
        objects4 = GameObject.FindGameObjectWithTag ("legDown4");
        objects5 = GameObject.FindGameObjectWithTag ("legUp1");
        objects6 = GameObject.FindGameObjectWithTag ("legUp2");
        objects7 = GameObject.FindGameObjectWithTag ("legUp3");
        objects8 = GameObject.FindGameObjectWithTag ("legUp4");
    }
    void Start()
    {
        z1 = z1Start; 
    }
    void Update()
    {
        repeat();
        if (xx <= -x_max || xx >= x_max) {
            if (runOnce) {
                up = !up; 
                change = true; 
                runOnce = false; 
            }
            if (z2 != z1Start && change && !knowBegan2) {
                knowBegan1 = true; 
                if  (z1 != z2 && know) {
                    z1 = z1 + 0.5; 
                    repeat();
                    return;
                } else {
                    know = false; 
                }
                if (z2 != z1Start) {
                    z2 = z2 - 0.5; 
                    repeat();
                } 
                if (z2 == z1Start) {
                    change = false; 
                    know = true; 
                    runOnce = true;
                    knowBegan1 = false; 
                }
            } 
            if (z1 != z1Start && change && !knowBegan1){
                knowBegan2 = true; 
                if (z2 != z1 && know) {
                    z2 = z2 + 0.5; 
                    repeat();
                    return;
                } else {
                    know = false; 
                }
                if (z1 != z1Start) {
                    z1 = z1 - 0.5; 
                    repeat();
                } 
                if (z1 == z1Start) {
                    change = false; 
                    know = true;
                    knowBegan2 = false; 
                    runOnce = true;
                }
            }
        }
        if (up && !change) {
            xx += 1; 
            xxx -= 1; 
        }
        if (!up && !change) {
            xx -= 1; 
            xxx += 1; 
        }
    }
    public void repeat() {
        z = z1; 
        x = xx; 
        calculate(); 
        a = a / -1;
        b = b - 180;
        objects5.GetComponent<LegUp1>().newRotation5 = new Vector3(0,0,ToSingle(a));
        objects6.GetComponent<LegUp2>().newRotation6 = new Vector3(0,0,ToSingle(a));
        objects1.GetComponent<LegDown1>().newRotation1 = new Vector3(0,0,ToSingle(a) - ToSingle(b));
        objects2.GetComponent<LegDown2>().newRotation2 = new Vector3(0,0,ToSingle(a) - ToSingle(b));
        z = z2; 
        x = xxx; 
        calculate2(); 
        a22 = a22 / -1;
        b2 = b2 - 180;
        objects7.GetComponent<LegUp3>().newRotation7 = new Vector3(0,0,ToSingle(a22));
        objects8.GetComponent<LegUp4>().newRotation8 = new Vector3(0,0,ToSingle(a22));
        objects3.GetComponent<LegDown3>().newRotation3 = new Vector3(0,0,ToSingle(a22) - ToSingle(b2));
        objects4.GetComponent<LegDown4>().newRotation4 = new Vector3(0,0,ToSingle(a22) - ToSingle(b2));
    }
    public void calculate()     //Debug.Log(a1);
    {
        if (y == 0) {y = 0.0000001;}

        gamma = Math.Atan(x / y) * 57.296;
        
        if (x < 0){
            L1 = x /-1; 
            L = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(L1, 2));

            a1 = Math.Asin(z / L) * 57.296;
            a2 = Math.Acos(( Math.Pow(L, 2) + Math.Pow(femur, 2) - Math.Pow(tibia, 2)) / (2 * femur * L)) * 57.296;
            a = a1 + a2 - 90;
        } else {
            L1 = x; 
            L = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(L1, 2));

            a1 = Math.Acos(z / L) * 57.296;
            a2 = Math.Acos(( Math.Pow(L, 2) + Math.Pow(femur, 2) - Math.Pow(tibia, 2)) / (2 * femur * L)) * 57.296;
            a = a1 + a2;
        }
        b = Math.Acos(( Math.Pow(tibia, 2 ) + Math.Pow(femur, 2) - Math.Pow(L, 2)) / (2 * tibia * femur)) * 57.296;
    }
    public void calculate2()     //Debug.Log(a1);
    {
        if (y == 0) {y = 0.0000001;}

        gamma2 = Math.Atan(x / y) * 57.296;

        if (x < 0){
            L1 = x /-1; 
            L = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(L1, 2));

            a1 = Math.Asin(z / L) * 57.296;
            a2 = Math.Acos(( Math.Pow(L, 2) + Math.Pow(femur, 2) - Math.Pow(tibia, 2)) / (2 * femur * L)) * 57.296;
            a22 = a1 + a2 - 90;
        } else {
            L1 = x; 
            L = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(L1, 2));

            a1 = Math.Acos(z / L) * 57.296;
            a2 = Math.Acos(( Math.Pow(L, 2) + Math.Pow(femur, 2) - Math.Pow(tibia, 2)) / (2 * femur * L)) * 57.296;
            a22 = a1 + a2;
        }
        b2 = Math.Acos(( Math.Pow(tibia, 2 ) + Math.Pow(femur, 2) - Math.Pow(L, 2)) / (2 * tibia * femur)) * 57.296;
    }
    public static float ToSingle(double value) 
    {
        return (float)value;
    }
}
