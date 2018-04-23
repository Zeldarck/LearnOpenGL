#version 330 core
in vec2 TexCoord;

out vec4 FragColor;

uniform sampler2D texture0;
uniform sampler2D texture1;
uniform float mixValue;

void main()
{
    FragColor = mix(texture(texture0, TexCoord), texture(texture1,  vec2(1,1) - TexCoord), mixValue);//vec4(TexCoord,0,0);//texture(texture1, TexCoord) * vec4(ourColor, 1.0);  
}