#version 330 core
out vec4 FragColor;

uniform float near = 0.1;
uniform float far = 100.0;
float linearDepth(float depth){
    float z = depth * 2.0f - 1.0;
    return (2.0 * near * far) / (far + near - z * (far - near));
}

void main()
{             
    //FragColor = vec4(1.0, 1.0, 1.0, 1.0);	
    //FragColor = vec4(vec3(gl_FragCoord.z), 1.0);
    float depth = linearDepth(gl_FragCoord.z) / far;
    FragColor = vec4(vec3(depth), 1.0);
}
