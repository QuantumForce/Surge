#pragma strict

var speed = 5.0;

function Start () {

}

function Update () {

var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
var z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
transform.Translate(x,0,z);
}