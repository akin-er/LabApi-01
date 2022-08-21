pipeline {
    agent { label 'ec2' }

    stages {
        stage('Build') {
            steps {
                echo 'Building'
                sh 'docker build --rm -t labapi-01:latest .'
            }
        }
    }
}
