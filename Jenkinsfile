pipeline {
    agent { label 'ec2' }

    stages {
        stage('Hello') {
            steps {
                echo 'Hello World'
                sh 'uname -a'
            }
        }
    }
}
