# GammaruSample

Unity 6 URP 2D 프로젝트에 세로 스크롤 슈팅용 스프라이트와 빈 씬 3개를 넣어 둔 템플릿 저장소입니다. 게임 로직은 없고, 다음 작업의 출발점으로 쓰는 용도의 뼈대입니다.

릴리스 다운로드: [Templete 릴리스](https://github.com/godekd3133/GammaruSample/releases/tag/Templete)

## 소개

- 커밋 5건이 모두 2025-03-14에 있습니다("Initial commit", "Moved Directory", "Create README.md", "Update README.md" 등). 저장소 설명은 없고, 용도에 대한 설명도 저장소에 적혀 있지 않습니다.
- 릴리스 `Templete`(2025-03-14)에는 설명 "Templete Project 6000.0.38f1"과 함께 `Templete.unitypackage` 한 개(약 200KB)가 첨부되어 있습니다. 같은 구성을 패키지로 받아 다른 프로젝트에 가져갈 수 있게 한 것으로 보입니다.

## 핵심 구현

이 저장소에는 직접 작성한 C# 게임 코드가 없습니다. 있는 것은 프로젝트 설정과 에셋입니다.

- 씬 3개: `TitleScene`, `MainScene`, `GameOverScene`. 세 파일의 크기가 모두 같아(9,947바이트) 기본 템플릿 씬 상태로 보입니다. 타이틀에서 본 게임으로, 게임 오버로 이어지는 흐름은 아직 연결되어 있지 않습니다.
- 렌더링 설정(`Assets/Settings/`): URP 2D 렌더러(`Renderer2D`), URP 에셋과 전역 설정, 기본 볼륨 프로필, 2D 라이트 씬 템플릿이 들어 있습니다.
- 입력 설정: `InputSystem_Actions.inputactions`로 새 Input System 기본 액션 맵을 사용하도록 되어 있습니다.
- 스프라이트(`Assets/Sprites/`): 플레이어, 적, 총알, 아이템, 폭발, UI, 배경 시트가 있습니다.
- 에셋 원본(`Assets/3rdParty/Vertical 2D Shooting BE4/`): 위 스프라이트의 원본 에셋 팩과 데모 씬입니다. 팩에 포함된 `Readme.asset`에 따르면 골드메탈의 BE4 강좌용 에셋 팩이며, 출처만 표기하면 상업적 사용을 포함해 자유롭게 쓸 수 있다고 안내되어 있습니다(Copyright 2021 Goldmetal).

## 프로젝트 구조

| 경로 | 내용 |
| --- | --- |
| `Assets/Scenes/` | `TitleScene`, `MainScene`, `GameOverScene` |
| `Assets/Settings/` | URP 2D 렌더러, URP 에셋, 볼륨 프로필, 입력 액션 |
| `Assets/Sprites/` | 슈팅 게임용 스프라이트 시트 10종 |
| `Assets/3rdParty/Vertical 2D Shooting BE4/` | 스프라이트 원본 팩, 데모 씬, 제공자 안내 |
| `Packages/manifest.json` | 패키지 목록 |
| `.vscode/` | VS Code 편집 설정 |

## 기술 스택

- Unity 6000.0.38f1 (`ProjectSettings/ProjectVersion.txt`)
- Universal Render Pipeline 17.0.3, 2D Feature Set 2.0.1, Input System 1.13.1, Multiplayer Center 1.0.0 (`Packages/manifest.json`)

## 실행 방법

1. Unity Hub에서 Unity 6000.0.38f1을 설치합니다.
2. 저장소를 프로젝트 폴더로 열고 `Assets/Scenes/MainScene.unity`를 엽니다. 에셋 팩의 동작 예시는 `Assets/3rdParty/Vertical 2D Shooting BE4/Demo/Demo.unity`에서 볼 수 있습니다.
3. 패키지로 가져오려면 릴리스의 `Templete.unitypackage`를 받아 다른 프로젝트에 임포트합니다.

## 현재 상태

템플릿 단계이며 마지막 커밋은 2025-03-14입니다. 스프라이트 에셋의 권리는 원 제공자(골드메탈)에게 있고, 이 저장소를 이어서 쓸 때도 출처 표기가 필요합니다. 이 문서는 당시 환경(Unity 6000.0.38f1) 기준으로 파일 구성을 읽고 정리한 것이며, 현재 환경에서 다시 열어 확인하지는 않았습니다.
